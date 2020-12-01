stuffs that i used: 
-asp.net core with an "api" template
-entityframework (sqlserver, tools and design)
-sql server for Database

notice:If you want, You can add migration file and create database by config "connectionstring" in Context and you also need to remark the constructor part before add migration file.
afterthat its good to create database with Updata-Database command.
Then, you have to add constructor with your connectionstring again(the one that you remark) and dont forget to addDbContext in Startup file.

Things i did:
-Created relational database with entityframework.
-the database has 3 entities which are Student, University and EnrollOrder (you can look for all my attribute in picture's folder and some of them cant be null.)
-about database relation that i did, i was using enrollOrder for being a relational table that has 2 foreign key, one's form Student id and another one is from University id.
The primary key of enrollOrder table will be a compound key of both foreign key.
-for the main part i create web api template and scaffold a migration for create relational database from models and context. And also scaffold controllers and do some config with GET and Post Method
-so i success to add a record into my relational database that has 3 entities. So, that meant i have 3 routes for do some work which are api/students, api/universities and api/enrollOrders
-GET method is for look for all records in each entity. And POST method is for add the record to an entity. 
-Post's return some weird exeption, Unfortunately i do not have enough time to fix that. But Get method is work absolutely fine.
-you can take a look for my database and some of screenshots of this implementation.
-Please forgive me for those line of stringconnection.

Thankyou for give me an oppotunity, I will wait for recieve some of feedbacks :)

Best regard


