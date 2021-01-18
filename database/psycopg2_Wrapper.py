import psycopg2

class database:
    def __init__(self):
        with open('password.txt') as f:
            lines = [line.rstrip() for line in f]
            
        self.database = lines[2]
        self.user = lines[0]
        self.password = lines[1] 
        self.host = lines[3]

    def connectToDatabase(self):
        conn = psycopg2.connect(
        database = self.database, 
        user = self.user, 
        password = self.password, 
        host = self.host)

        return conn

    def runQuery(self, sql):  
        conn = self.connectToDatabase()
        cursor = conn.cursor()
        cursor.execute(sql)
        if cursor.description is not None:
            result = cursor.fetchone()
            conn.close()
            return result
        else:
            conn.commit()
            conn.close()

    def getColumnNames(self, tablename):
        conn = self.connectToDatabase()
        cursor = conn.cursor()
        cursor.execute("Select * FROM " + tablename + " limit 0;")
        columnNames = [desc[0] for desc in cursor.description]
        conn.close()
        return columnNames