#!/bin/sh
sqlite3 output/Artists.db <<EOF
CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
    "MigrationId" TEXT NOT NULL CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY,
    "ProductVersion" TEXT NOT NULL
);

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
    "IsDeleted" INTEGER NOT NULL,
    "EmployeeId" INTEGER NULL,
    CONSTRAINT "FK_Albums_Employees_EmployeeId" FOREIGN KEY ("EmployeeId") REFERENCES "Employees" ("Id")
);

CREATE INDEX "IX_Albums_EmployeeId" ON "Albums" ("EmployeeId");

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20220828091534_GlobalQueryFilters', '6.0.2');

INSERT INTO Employees values(1,'Max','Bello',25);
INSERT INTO Employees values(2,'Francis','Ojukwu',34);
INSERT INTO Employees values(3,'Martha','Bertha',19);

INSERT INTO Albums values(1,'Blue Fire',2000,0,2);
INSERT INTO Albums values(2,'Raging Heart',3850,1,3);
INSERT INTO Albums values(3,'Fixated on you',4000,1,1);

COMMIT;
EOF
