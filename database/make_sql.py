import psycopg2
import textwrap
import inspect

with open('password.txt') as f:
    lines = [line.rstrip() for line in f]
    
username = lines[0]
pg_password = lines[1]
databaseName = lines[2]
hostAddress = lines[3]
conn = psycopg2.connect(database = databaseName, user = username, password = pg_password, host = hostAddress)
cursor = conn.cursor()

def newMove():
    while(True):
        moveFile = open("moves.sql", "a")
        moveName = input("\nenter move name: ")
        moveType = input("enter move type: ")
        moveCatagory = input("enter catagory: ")
        movePower = input("enter power: ")
        moveAccuracy = input("enter accuracy: ")
        movePP = input("enter PP: ")
        movePriority = input("enter priority: ")
        moveDescription = input("enter description: ")
        optionalEffect = input("does the move have a secondary effect? (y/n): ")

        if optionalEffect == 'n':
            sql = """INSERT INTO pokemon_db.moves VALUES('%s', '%s', '%s', %s, %d, %d, "%s");
            """ % (moveName, moveType, moveCatagory, movePower, moveAccuracy, movePP, movePriority, moveDescription)
        else:
            sql = "select effect_name from pokemon_db.effect_types;"
            cursor.execute(sql)
            effects = cursor.fetchall()
            for i in range(0, len(effects)):
                print(i + "." + effects[i])
            index = input("\nenter effect type (number):")
            chance = input("\nenter percent chance effect can occur:")
            sql = """BEGIN
                INSERT INTO pokemon_db.moves VALUES('%s', '%s', '%s', %s, %d, %d, "%s");
                INSERT INTO pokemon_db.move_effect VALUES('%s', '%s', %s)
                COMMIT
            """ % (moveName, moveType, moveCatagory, movePower, moveAccuracy, movePP, movePriority, moveDescription, moveName, effects[index], chance)

        moveFile.write(sql + "\n")
        another = input("add another? (y/n): ")
        if another == "n":
            moveFile.close()
            break

def newPokemon():
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
        BEGIN
        INSERT INTO pokemon_db.pokemon VALUES(DEFAULT,%s, '%s', '%s', %s, %s, '%s', '%s', '%s');
        INSERT INTO pokemon_db.pokemon_stats VALUES(%s, %s, %s, %s, %s, %s, %s);
        """ % (pokedex, name, species, height, weight, growthRate, eggGroup, description, hp, attack, defense, specialAttack, specialDefense, speed, total)

        cursor.execute("SELECT COUNT(*) FROM pokemon_db.pokemon;")
        currentID = cursor.fetchone()
        if currentID[0] != 0:
            cursor.execute("SELECT nextval(pg_get_serial_sequence('pokemon_db.pokemon', 'pokemon_id'));")
            currentID = cursor.fetchone()
        else:
            currentID[0] = 1

        numMoves = int(input("How many moves does it learn by level up? "))
        for i in range(numMoves):
            moveName = input("enter move name:")
            moveLevel = input("enter move level:")
            sql = sql + """INSERT INTO pokemon_db.levelup_learned_moves VALUES(%s, '%s', %s);
            """ % (currentID[0], moveName, moveLevel)

        numMoves = int(input("How many moves does it learn by TM? "))
        for i in range(numMoves):
            moveName = input("enter move name:")
            tm = input("enter tm id:")
            sql = sql + """INSERT INTO pokemon_db.tm_learned_moves VALUES(%s, '%s', '%s');
            """ % (currentID[0], moveName, tm)

        numMoves = int(input("How many moves does it learn by TR? "))
        for i in range(numMoves):
            moveName = input("enter move name:")
            tr = input("enter tr id:")
            sql = sql + """INSERT INTO pokemon_db.tr_learned_moves VALUES(%s, '%s', '%s');
            """ % (currentID[0], moveName, tr)

        numMoves = int(input("How many moves does it learn by egg moves? "))
        for i in range(numMoves):
            moveName = input("enter move name:")
            sql = sql + """INSERT INTO pokemon_db.egg_moves VALUES(%s, '%s')
            """ % (currentID[0], moveName)

        numMoves = input("does it learn a move on evolution? (y/n): ")
        if numMoves == "y":
            moveName = input("enter move name:")
            sql = sql + """INSERT INTO pokemon_db.evolution_learned_moves VALUES(%s, '%s');
            """ % (currentID[0], moveName)

        sql = sql + "\nCOMMIT"
        sqlFile = open("pokemon.sql", "a")
        sqlFile.write(inspect.cleandoc(sql) + "\n\n")
        another = input("add another? (y/n): ")
        if another == "n":
            sqlFile.close()
            break

def newEvolution():
    pass

def addToTable():
    cursor.execute("""SELECT table_name FROM information_schema.tables WHERE table_schema = 'pokemon_db'
    and table_name not in (
        'pokemon', 
        'pokemon_abilities',
        'pokemon_evolution',
        'pokemon_stats',
        'pokemon_types',
        'moves',
        'move_effect',
        'items',
        'egg_moves',
        'evolution_group',
        'evolution_learned_moves',
        'levelup_learned_moves',
        'tr_learned_moves',
        'tm_learned_moves', 
        'abilities'
    );""")
    result = cursor.fetchall()

    print("\nlist of tables\n")
    for i in result:
        print("\t" + i[0])
    
    tableName = input("\nenter a table name: ")
    sql = "Select * FROM pokemon_db.%s LIMIT 0" % (tableName)
    cursor.execute(sql)
    columnNames = [desc[0] for desc in cursor.description]

    numToEnter = int(input("enter number of entries to add: "))
    sqlFile = open(tableName + ".sql", "a")
    for i in range(0, numToEnter):
        insertSQL = "INSERT INTO pokemon_db." + tableName + " VALUES("
        for j in range(0,len(columnNames)):
            columnSQL = "select data_type from information_schema.columns where column_name = '%s';" % (columnNames[j])
            cursor.execute(columnSQL)
            result = cursor.fetchone()

            value = input("enter " + columnNames[j] + ": ")
            if result[0] == "integer":
                insertSQL = insertSQL + value
            else:
                insertSQL = insertSQL + "'" + value + "'"
            if j != len(columnNames) - 1:
                insertSQL = insertSQL + ","

        sqlFile.write(insertSQL + ");")
        cursor.execute(insertSQL + ");")
        
    sqlFile.close()


optionList = """\nselect an option\n
            1.new move
            2.new pokemon
            3.new evolution chain
            4.add to table"""
print("Pokmon database sql maker\n" + optionList)
option = int(input("\nNumber: "))

if option == 1:
    newMove()
elif option == 2:
    newPokemon()
elif option == 3:
    newEvolution()
elif option == 4:
    addToTable()
