#!/bin/sh
sqlite3 output/School.db <<EOF
BEGIN TRANSACTION;

CREATE TABLE "Departments" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_Departments" PRIMARY KEY AUTOINCREMENT,
    "Title" TEXT NULL,
    "HOD" TEXT NULL
);

CREATE TABLE "Students" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_Students" PRIMARY KEY AUTOINCREMENT,
    "FirstName" TEXT NULL,
    "LastName" TEXT NULL,
    "DepartmentCode" INTEGER NOT NULL
);

CREATE TABLE "Instructors" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_Instructors" PRIMARY KEY AUTOINCREMENT,
    "FirstName" TEXT NULL,
    "LastName" TEXT NULL,
    "DepartmentCode" INTEGER NOT NULL,
    CONSTRAINT "FK_Instructors_Departments_DepartmentCode" FOREIGN KEY ("DepartmentCode") REFERENCES "Departments" ("Id") ON DELETE CASCADE
);

CREATE INDEX "IX_Instructors_DepartmentCode" ON "Instructors" ("DepartmentCode");

INSERT INTO "Departments" ("Title","HOD") VALUES ('Engineering','Marthias Donald');
INSERT INTO "Departments" ("Title","HOD") VALUES ('Medicine','Chris Fleming');

INSERT INTO "Instructors" ("FirstName","LastName","DepartmentCode") VALUES ('Isaac','Andrews',2);
INSERT INTO "Instructors" ("FirstName","LastName","DepartmentCode") VALUES ('Abraham','Olu',1);
INSERT INTO "Instructors" ("FirstName","LastName","DepartmentCode") VALUES ('Bola','Obiora',2);
INSERT INTO "Instructors" ("FirstName","LastName","DepartmentCode") VALUES ('Aniekan','Umoh',2);

INSERT INTO "Students" ("FirstName","LastName","DepartmentCode") VALUES ('Prince','Rock',1);
INSERT INTO "Students" ("FirstName","LastName","DepartmentCode") VALUES ('Susan','Crystal',2);
INSERT INTO "Students" ("FirstName","LastName","DepartmentCode") VALUES ('Femi','Ayorinde',2);
INSERT INTO "Students" ("FirstName","LastName","DepartmentCode") VALUES ('Bob','Rawlins',1);
INSERT INTO "Students" ("FirstName","LastName","DepartmentCode") VALUES ('Johanesson','Kipp',2);
INSERT INTO "Students" ("FirstName","LastName","DepartmentCode") VALUES ('Blessing','Okon',1);

COMMIT;
EOF