CREATE TABLE IF NOT EXISTS Employees (
    "Id" INTEGER NOT NULL,
    "FirstName" TEXT NOT NULL,
    "LastName" TEXT NOT NULL,
    "Age" INTEGER NOT NULL,
    PRIMARY KEY("Id" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS Studios (
    "Id" INTEGER NOT NULL,
    "HouseNumber" INTEGER NOT NULL,
    "City" TEXT NOT NULL,
    "EmployeeId" INTEGER NOT NULL UNIQUE,
    PRIMARY KEY("Id" AUTOINCREMENT),
    FOREIGN KEY (EmployeeId) REFERENCES Employees (Id)
);
CREATE TABLE IF NOT EXISTS Albums (
    "Id" INTEGER NOT NULL,
    "Title" TEXT NOT NULL,
    "Price" REAL NOT NULL,
    "EmployeeId" INTEGER NOT NULL,
    PRIMARY KEY("Id" AUTOINCREMENT),
    FOREIGN KEY (EmployeeId) REFERENCES Employees (Id)
);
CREATE TABLE IF NOT EXISTS Tags (
    "Id" INTEGER NOT NULL,
    "Title" TEXT NOT NULL,
    PRIMARY KEY("Id" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS AlbumTags(
    AlbumId INTEGER,
    TagId INTEGER,
    FOREIGN KEY(AlbumId) REFERENCES Albums(Id) ON DELETE CASCADE,
    FOREIGN KEY(TagId) REFERENCES Tags(Id) ON DELETE CASCADE,
    PRIMARY KEY(AlbumId, TagId)
);
INSERT INTO Employees values(1,'Max','Bello',25);
INSERT INTO Employees values(2,'Francis','Ojukwu',34);
INSERT INTO Employees values(3,'Martha','Bertha',19);

INSERT INTO Studios values(1,13,'Frankville',3);
INSERT INTO Studios values(2,209,'Ikoyi',1);
INSERT INTO Studios values(3,44,'Lekki',2);

INSERT INTO Albums values(1,'Blue Fire',2000,2);
INSERT INTO Albums values(2,'Raging Heart',3850,3);
INSERT INTO Albums values(3,'Fixated on you',4000,1);
INSERT INTO Albums values(4,'Purple symphony',4800,1);

INSERT INTO Tags values(1, 'Rock');
INSERT INTO Tags values(2, 'RnB');
INSERT INTO Tags values(3, 'Jazz');
INSERT INTO Tags values(4, 'Country');
INSERT INTO Tags values(5, 'Classical');

INSERT INTO AlbumTags values(1,2);
INSERT INTO AlbumTags values(2,3);
INSERT INTO AlbumTags values(3,4);
INSERT INTO AlbumTags values(4,1);




















