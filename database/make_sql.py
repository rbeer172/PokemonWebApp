import re
from psycopg2_Wrapper import database

def newPokemon(db):
    while(True):
        pokedex = input("\nenter pokedex number: ")  
        name = input("enter name: ")
        species = input("enter species: ")
        height = input("enter height: ")
        weight = input("enter weight: ")
        growthRate = input("enter growth rate: ")
        eggGroup = input("enter egg group: ")
        description = input("enter pokedex entry: ")
        print("\nBASE STATS")
        total = input("\nenter total: ")  
        hp = input("enter hp: ")
        attack = input("enter attack: ")
        defense = input("enter defense: ")
        specialAttack = input("enter special Attack: ")
        specialDefense = input("enter special Defense: ")
        speed = input("enter speed: ")

        sql = "--pokemon:" + name + """
        BEGIN;
        INSERT INTO pokemon_db.pokemon 
        VALUES(DEFAULT,%s, '%s', '%s', %s, %s, '%s', '%s', '%s', %s, %s, %s, %s, %s, %s, %s);
        """ % (pokedex, name, species, height, weight, growthRate, eggGroup, description, 
                hp, attack, defense, specialAttack, specialDefense, speed, total)

        currentID = db.runQuery("SELECT nextval(pg_get_serial_sequence('pokemon_db.pokemon', 'pokemon_id'));")

        numMoves = int(input("How many types? (1 or 2): "))
        for i in range(numMoves):
            typing = input("enter type:")
            sql = sql + """INSERT INTO pokemon_db.pokemon_types VALUES(%s, '%s');
            """ % (currentID[0], typing)

        numMoves = int(input("How many abilities can it learn? "))
        for i in range(numMoves):
            name = input("enter ability name:")
            hidden = input("is the ability hidden? (y/n): ")
            sql = sql + """INSERT INTO pokemon_db.pokemon_abilites VALUES(%s, '%s', %s);
            """ % (currentID[0], name, "TRUE" if hidden == "y" else "FALSE")
        
        numMoves = int(input("How many egg groups is it in? (1 or 2): "))
        for i in range(numMoves):
            name = input("enter group name:")
            sql = sql + """INSERT INTO pokemon_db.pokemon_egg_group VALUES(%s, '%s');
            """ % (currentID[0], name)

        numMoves = int(input("How many moves does it learn by level up? "))
        for i in range(numMoves):
            name = input("enter move name:")
            moveLevel = input("enter move level:")
            sql = sql + """INSERT INTO pokemon_db.levelup_learned_moves VALUES(%s, '%s', %s);
            """ % (currentID[0], name, moveLevel)

        numMoves = int(input("How many moves does it learn by TM? "))
        for i in range(numMoves):
            name = input("enter move name:")
            tm = input("enter tm id:")
            sql = sql + """INSERT INTO pokemon_db.tm_learned_moves VALUES(%s, '%s', %s);
            """ % (currentID[0], name, tm)

        numMoves = int(input("How many moves does it learn by TR? "))
        for i in range(numMoves):
            name = input("enter move name:")
            tr = input("enter tr id:")
            sql = sql + """INSERT INTO pokemon_db.tr_learned_moves VALUES(%s, '%s', %s);
            """ % (currentID[0], name, tr)

        numMoves = int(input("How many moves does it learn by egg moves? "))
        for i in range(numMoves):
            name = input("enter move name:")
            sql = sql + """INSERT INTO pokemon_db.egg_moves VALUES(%s, '%s')
            """ % (currentID[0], name)

        numMoves = input("Does it learn a move on evolution? (y/n): ")
        if numMoves == "y":
            name = input("enter move name:")
            sql = sql + """INSERT INTO pokemon_db.evolution_learned_moves VALUES(%s, '%s');
            """ % (currentID[0], name)

        sql = sql + "COMMIT;"
        sqlFile = open("pokemon.sql", "a")
        sqlFile.write(re.sub(r'(^[ \t]+|[ \t]+(?=:))', '', sql, flags=re.M))
        sqlFile.close()
        db.runQuery(sql)

        another = input("add another? (y/n): ")
        if another == "n":
            break

def newEvolution(db):
    while(True):
        chainNum = int(input("enter number of pokemon in chain: "))
        sql = "BEGIN\nINSERT INTO pokemon_db.evolution_group VALUES(DEFAULT);\n"

        for i in range(0,chainNum):
            pokemonName = input("enter pokemon name:")
            order = input("enter the pokemon's position in the chain(number): ")
            pokemonID = db.runQuery("select pokemon_id from pokemon_db.pokemon where pokemon_name = " + pokemonName)
            nextID = db.runQuery("SELECT nextval(pg_get_serial_sequence('pokemon_db.evolution_group', 'group_id'));")

            print("\t\n1.level-up\n2.item\n3.friendship\n4.trade\n5.other\n")
            evolutionType = int(input("select a evolution option(number): "))
            if evolutionType == 1:
                level = input("enter level: ")
                sql = sql + """INSERT INTO pokemon_db.pokemon_evolution 
                VALUES(%s, %s, %s, %s, NULL, NULL, NULL, FALSE, NULL ,FALSE, NULL)
                """ % (pokemonID[0], nextID[0], order, level)

            elif evolutionType == 2:
                item = input("enter item name: ")
                sql = sql + """INSERT INTO pokemon_db.pokemon_evolution 
                VALUES(%s, %s, %s, NULL, %s, NULL, NULL, FALSE, NULL ,FALSE, NULL)
                """ % (pokemonID[0], nextID[0], order, item)
                
            elif evolutionType == 3:
                option = input("Does the evolution happen at certain time of day? (y/n): ")
                if option == "y":
                    time = input("enter daytime or nighttime: ")
                    sql = sql + """INSERT INTO pokemon_db.pokemon_evolution 
                VALUES(%s, %s, %s, NULL, NULL, NULL, '%s', TRUE, NULL ,FALSE, NULL)
                """ % (pokemonID[0], nextID[0], order, time)
                else:
                    sql = sql + """INSERT INTO pokemon_db.pokemon_evolution 
                VALUES(%s, %s, %s, NULL, NULL, NULL, NULL, TRUE, NULL ,FALSE, NULL)
                """ % (pokemonID[0], nextID[0], order)

            elif evolutionType == 4:
                option = input("Does the pokemon need a held item? (y/n): ")
                if option == "y":
                    item = input("enter item name: ")
                    sql = sql + """INSERT INTO pokemon_db.pokemon_evolution 
                VALUES(%s, %s, %s, NULL, '%s', NULL, NULL, FALSE, NULL ,TRUE, NULL)
                """ % (pokemonID[0], nextID[0], order, item)
                else:
                    sql = sql + """INSERT INTO pokemon_db.pokemon_evolution 
                VALUES(%s, %s, %s, NULL, NULL, NULL, NULL, FALSE, NULL ,TRUE, NULL)
                """ % (pokemonID[0], nextID[0], order)

            elif evolutionType == 5:
                columnNames = db.getColumnNames("pokemon_db.pokemon_evolution")
                for j in range(0,len(columnNames)):
                    insertQuery = "INSERT INTO pokemon_db.pokemon_evolution VALUES("
                    columnTypes = "select data_type from information_schema.columns where column_name = '%s';" % (columnNames[j])
                    result = db.runQuery(columnTypes)

                    value = input("enter " + columnNames[j] + "(enter NULL if not applicable): ")
                    if result[0] == "integer" or value == "NULL":
                        insertQuery = insertQuery + value
                    else:
                        insertQuery = insertQuery + "'" + value + "'"
                    if j != len(columnNames) - 1:
                        insertQuery = insertQuery + ","
                sql = sql + insertQuery + ");"

        file = open("evolution.sql", "a")
        file.write(re.sub(r'(^[ \t]+|[ \t]+(?=:))', '', sql, flags=re.M))
        file.close()
        db.runQuery(sql)

        another = input("add another? (y/n): ")
        if another == "n":
            break

def fillTypeEffectiveness(db):
    types = db.runQuery("select * from pokemon_db.typing")
    queue = types
    for typing in types:
        sql = "--type:%s\nBEGIN;\n" % (typing[0])
        print("\nenter data for " + typing[0] + " as attacking\n")
        for i in queue:
            print("\nattacking -> defending")
            print(typing[0] + "  ->  " + i[0])
            multiplier = input("enter multiplier: ")
            sql = sql + """INSERT INTO pokemon_db.type_effectiveness VALUES('%s', '%s', %s);
            """ % (typing[0], i[0], multiplier)
        
        print("\nenter data for " + typing[0] + " as defending\n")
        for i in queue:
            if i[0] != typing[0]:
                print("\nattacking -> defending")
                print(i[0] + "  ->  " + typing[0])
                multiplier = input("enter multiplier: ")
                sql = sql + """INSERT INTO pokemon_db.type_effectiveness VALUES('%s', '%s', %s);
                """ % (i[0], typing[0], multiplier)

        sql = sql + "COMMIT;\n"
        sqlFile = open("type_effectiveness.sql", "a")
        sqlFile.write(re.sub(r'(^[ \t]+|[ \t]+(?=:))', '', sql, flags=re.M))
        sqlFile.close()
        db.runQuery(sql)
        queue.pop(0)

def addToTable(db):
    result = db.runQuery("""
            SELECT table_name 
            FROM information_schema.tables 
            WHERE table_schema = 'pokemon_db'
            AND table_name NOT IN (
            'pokemon', 
            'pokemon_abilities',
            'pokemon_evolution',
            'pokemon_stats',
            'pokemon_types',
            'pokemon_egg_group',
            'moves',
            'egg_moves',
            'evolution_group',
            'evolution_learned_moves',
            'levelup_learned_moves',
            'tr_learned_moves',
            'tm_learned_moves' );""")

    print("\nlist of tables\n")
    for i in result:
        print("\t" + i[0])
    
    tableName = input("\nenter a table name: ")
    columnNames = db.getColumnNames("pokemon_db." + tableName)

    numToEnter = int(input("enter number of entries to add: "))
    sqlFile = open(tableName + ".sql", "a")
    for i in range(0, numToEnter):
        insertSQL = "INSERT INTO pokemon_db." + tableName + " VALUES("
        for j in range(0,len(columnNames)):
            columnSQL = "select distinct data_type from information_schema.columns where column_name = '%s';" % (columnNames[j])
            result = db.runQuery(columnSQL)

            value = input("enter " + columnNames[j] + ": ")
            if result[0] == "integer":
                insertSQL = insertSQL + value
            else:
                insertSQL = insertSQL + "'" + value + "'"
            if j != len(columnNames) - 1:
                insertSQL = insertSQL + ","

        sqlFile.write(insertSQL + ");\n")
        db.runQuery(insertSQL + ");")
        
    sqlFile.close()

def main():
    optionList = """\nselect an option\n
                1.new pokemon
                2.new evolution chain(all pokemon must be added first)
                3.new type chart
                4.add to table"""
    print("Pokmon database sql maker\n" + optionList)
    option = int(input("\nNumber: "))
    db = database()
    if option == 1:
        newPokemon(db)
    elif option == 2:
        newEvolution(db)
    elif option == 3:
        fillTypeEffectiveness(db)
    elif option == 4:
        addToTable(db)

main()