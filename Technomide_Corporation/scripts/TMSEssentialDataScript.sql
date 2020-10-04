use [TheProject]
----------------------------------------------
SET IDENTITY_INSERT dbo.RoleTable ON;  

INSERT INTO RoleTable(Role_ID,RoleName)
VALUES (1,'Owner');

INSERT INTO RoleTable(Role_ID,RoleName)
VALUES (2,'Manager');

INSERT INTO RoleTable(Role_ID,RoleName)
VALUES (3,'Student');

SET IDENTITY_INSERT dbo.RoleTable OFF;

-----------------------------------
SET IDENTITY_INSERT dbo.StatusTable ON;  

INSERT INTO StatusTable(State_ID,Name)
VALUES (1,'present');

INSERT INTO StatusTable(State_ID,Name)
VALUES (2,'leave');

INSERT INTO StatusTable(State_ID,Name)
VALUES (3,'absent');

INSERT INTO StatusTable(State_ID,Name)
VALUES (4,'late');

INSERT INTO StatusTable(State_ID,Name)
VALUES (5,'present');

SET IDENTITY_INSERT dbo.StatusTable OFF;
--------------------------------------------------------

SET IDENTITY_INSERT dbo.GenderTable ON;  

INSERT INTO GenderTable(G_ID,GenderName)
VALUES (1,'Male');

INSERT INTO GenderTable(G_ID,GenderName)
VALUES (2,'Female');

INSERT INTO GenderTable(G_ID,GenderName)
VALUES (3,'Others');

SET IDENTITY_INSERT dbo.GenderTable OFF; 

------------------------------------------