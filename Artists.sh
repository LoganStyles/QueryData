#!/bin/sh
sqlite3 output/Artists.db <<EOF
BEGIN TRANSACTION;

CREATE TABLE "Employees" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_Employees" PRIMARY KEY AUTOINCREMENT,
    "FirstName" TEXT NULL,
    "LastName" TEXT NULL,
    "Age" INTEGER NOT NULL
);

CREATE TABLE "Albums" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_Albums" PRIMARY KEY AUTOINCREMENT,
    "Title" TEXT NULL,
    "Price" REAL NOT NULL,
    "EmployeeId" INTEGER NULL,
    CONSTRAINT "FK_Albums_Employees_EmployeeId" FOREIGN KEY ("EmployeeId") REFERENCES "Employees" ("Id")
);

CREATE INDEX "IX_Albums_EmployeeId" ON "Albums" ("EmployeeId");

INSERT INTO Employees values(1,'Max','Bello',25);
INSERT INTO Employees values(2,'Francis','Ojukwu',34);
INSERT INTO Employees values(3,'Martha','Bertha',19);

INSERT INTO Albums values(1,'Blue Fire',2000,2);
INSERT INTO Albums values(2,'Raging Heart',3850,3);
INSERT INTO Albums values(3,'Fixated on you',4000,1);
INSERT INTO Albums values(4,'Great love starts small',4000,1);

COMMIT;
EOF
