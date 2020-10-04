Use [TheProject]
SET IDENTITY_INSERT dbo.TypeTable ON;  

INSERT INTO TypeTable(T_ID,TypeName)
VALUES (1,'Physical');
INSERT INTO TypeTable(T_ID,TypeName)
VALUES (2,'Remotely');

SET IDENTITY_INSERT dbo.TypeTable OFF;

-----------------------------------------  

SET IDENTITY_INSERT dbo.GenderTable ON;  

INSERT INTO GenderTable(G_ID,GenderName)
VALUES (1,'Male');

INSERT INTO GenderTable(G_ID,GenderName)
VALUES (2,'Female');

INSERT INTO GenderTable(G_ID,GenderName)
VALUES (3,'Others');

SET IDENTITY_INSERT dbo.GenderTable OFF; 

------------------------------------------

SET IDENTITY_INSERT dbo.DesignationTable ON;  

INSERT INTO DesignationTable(D_ID,PostName)
VALUES (1,'Manager');

INSERT INTO DesignationTable(D_ID,PostName)
VALUES (2,'Project Manager');

INSERT INTO DesignationTable(D_ID,PostName)
VALUES (3,'Trainee Engineer');

INSERT INTO DesignationTable(D_ID,PostName)
VALUES (4,'Senior Software Engineer');

INSERT INTO DesignationTable(D_ID,PostName)
VALUES (5,'Project Lead');

SET IDENTITY_INSERT dbo.DesignationTable OFF; 

---------------------------------------------------

SET IDENTITY_INSERT dbo.QualificationTable ON;  

INSERT INTO QualificationTable(Q_ID,QName)
VALUES (1,'Graduate');

INSERT INTO QualificationTable(Q_ID,QName)
VALUES (2,'Undergraduate');

INSERT INTO QualificationTable(Q_ID,QName)
VALUES (3,'Master');

INSERT INTO QualificationTable(Q_ID,QName)
VALUES (4,'PHD');

INSERT INTO QualificationTable(Q_ID,QName)
VALUES (5,'Diploma');

SET IDENTITY_INSERT dbo.QualificationTable OFF;
 
------------------------------------------------------
SET IDENTITY_INSERT dbo.EmployeeTable ON;  

INSERT INTO EmployeeTable(E_ID,Name,F_Name,CNIC,DOB,Address,Agreement,T_ID,G_ID,D_ID,Q_ID,Phone1,Phone2,Employee_ID,Salary)
VALUES (1,'Ali','khan','1234-4234-123','2020-08-12','A-600 Gulshan-e-hadeed Phase 2','1 year job contract',1,1,1,1,'0333-3401615','0311-4585581','1','5000');

INSERT INTO EmployeeTable(E_ID,Name,F_Name,CNIC,DOB,Address,Agreement,T_ID,G_ID,D_ID,Q_ID,Phone1,Phone2,Employee_ID,Salary)
VALUES (2,'Sana','Akram','4321-5234-124','2000-01-13','A-700 Gulshan-e-hadeed Phase 1','5 year job contract',2,2,2,2,'0333-3401615','0311-4585581','2','6000');

INSERT INTO EmployeeTable(E_ID,Name,F_Name,CNIC,DOB,Address,Agreement,T_ID,G_ID,D_ID,Q_ID,Phone1,Phone2,Employee_ID,Salary)
VALUES (3,'Aqsa','Bilal','3789-6234-125','2005-02-14','A-12 Block A steel town','6 month job contract',1,2,3,3,'0333-3401615','0311-4585581','3','7000');

INSERT INTO EmployeeTable(E_ID,Name,F_Name,CNIC,DOB,Address,Agreement,T_ID,G_ID,D_ID,Q_ID,Phone1,Phone2,Employee_ID,Salary)
VALUES (4,'Abbas','Haris','1452-7234-126','2006-04-15','A-890 DHA Phase 2','2 year job contract',2,1,4,4,'0333-3401615','0311-4585581','4','8000');

INSERT INTO EmployeeTable(E_ID,Name,F_Name,CNIC,DOB,Address,Agreement,T_ID,G_ID,D_ID,Q_ID,Phone1,Phone2,Employee_ID,Salary)
VALUES (5,'Yousra','Hasnain','9876-8234-127','2007-05-16','A-590 Phase 2 Green City','3 month job contract',1,2,5,5,'0333-3401615','0311-4585581','5','9000');

SET IDENTITY_INSERT dbo.EmployeeTable OFF;
 
------------------------------------------------------
SET IDENTITY_INSERT dbo.SkillsTable ON;  

INSERT INTO SkillsTable(S_ID,SkillName)
VALUES (1,'software enginner');

INSERT INTO SkillsTable(S_ID,SkillName)
VALUES (2,'computer scientist');

INSERT INTO SkillsTable(S_ID,SkillName)
VALUES (3,'web developer');

INSERT INTO SkillsTable(S_ID,SkillName)
VALUES (4,'hardware Engineer');

INSERT INTO SkillsTable(S_ID,SkillName)
VALUES (5,'marketing');

SET IDENTITY_INSERT dbo.SkillsTable OFF; 
------------------------------------------------------
SET IDENTITY_INSERT dbo.EmployeeSkillTable ON;  

INSERT INTO EmployeeSkillTable(ES_ID,E_ID,S_ID)
VALUES (1,1,1);

INSERT INTO EmployeeSkillTable(ES_ID,E_ID,S_ID)
VALUES (2,2,2);

INSERT INTO EmployeeSkillTable(ES_ID,E_ID,S_ID)
VALUES (3,3,3);

INSERT INTO EmployeeSkillTable(ES_ID,E_ID,S_ID)
VALUES (4,4,4);

INSERT INTO EmployeeSkillTable(ES_ID,E_ID,S_ID)
VALUES (5,5,5);

SET IDENTITY_INSERT dbo.EmployeeSkillTable OFF; 
------------------------------------------------------
SET IDENTITY_INSERT dbo.ConsultantTable ON;  

INSERT INTO ConsultantTable(C_ID,Name,F_Name,DOB,G_ID,Address,Phone1,Phone2,Cons_ID)
VALUES (1,'Younus','Abdullah','2000-08-11',1,'A-500 gulshan-e-hadeed phase 2','0333-5678901','0311-1675467','1');

INSERT INTO  ConsultantTable(C_ID,Name,F_Name,DOB,G_ID,Address,Phone1,Phone2,Cons_ID)
VALUES (2,'Ayesha','asif','2000-09-12',2,'A-400 gulshan-e-hadeed phase 1','0311-0986744','0300-2678167','2');

INSERT INTO ConsultantTable(C_ID,Name,F_Name,DOB,G_ID,Address,Phone1,Phone2,Cons_ID)
VALUES (3,'asad','talha','2000-10-13',1,'A-300 steel town Block b','0322-4325671','0333-3678345','3');

INSERT INTO ConsultantTable(C_ID,Name,F_Name,DOB,G_ID,Address,Phone1,Phone2,Cons_ID)
VALUES (4,'Aiman','basit','2000-11-14',2,'A-200 gulshan-e-hadeed phase 1','0344-0864489','0301-4678986','4');

INSERT INTO ConsultantTable(C_ID,Name,F_Name,DOB,G_ID,Address,Phone1,Phone2,Cons_ID)
VALUES (5,'hairs','mesum','2000-12-15',1,'A-100 Shah town near Famous Bakery','0355-4561230','0330-5567893','5');

SET IDENTITY_INSERT dbo.ConsultantTable OFF; 

------------------------------------------------
SET IDENTITY_INSERT dbo.ProjectTable ON;  

INSERT INTO ProjectTable(Pro_ID,Date_Of_Start,Name,Description,C_ID,Amount,Date_Of_Completion,Date_Of_Delivery,Project_Date)
VALUES (1,'2020-01-01','Symbol to speech','hardware project',1,'50000','2020-02-02','2020-03-03','2019-12-12');

INSERT INTO ProjectTable(Pro_ID,Date_Of_Start,Name,Description,C_ID,Amount,Date_Of_Completion,Date_Of_Delivery,Project_Date)
VALUES (2,'2021-01-01','school managment','.net based project',2,'60000','2021-02-02','2021-03-03','2020-12-12');

INSERT INTO ProjectTable(Pro_ID,Date_Of_Start,Name,Description,C_ID,Amount,Date_Of_Completion,Date_Of_Delivery,Project_Date)
VALUES (3,'2022-01-01','Symbol to speech','hardware project',3,'70000','2022-02-02','2022-03-03','2021-12-12');

INSERT INTO ProjectTable(Pro_ID,Date_Of_Start,Name,Description,C_ID,Amount,Date_Of_Completion,Date_Of_Delivery,Project_Date)
VALUES (4,'2023-01-01','Symbol to speech','hardware project',4,'80000','2023-02-02','2023-03-03','2022-12-12');

INSERT INTO ProjectTable(Pro_ID,Date_Of_Start,Name,Description,C_ID,Amount,Date_Of_Completion,Date_Of_Delivery,Project_Date)
VALUES (5,'2024-01-01','Symbol to speech','hardware project',5,'90000','2024-02-02','2024-03-03','2023-12-12');

SET IDENTITY_INSERT dbo.ProjectTable OFF;
---------------------------------------------------
SET IDENTITY_INSERT dbo.ProjectAssignedTable ON;  

INSERT INTO ProjectAssignedTable(PA_ID,Pro_ID,E_ID)
VALUES (1,1,1);

INSERT INTO ProjectAssignedTable(PA_ID,Pro_ID,E_ID)
VALUES (2,2,2);

INSERT INTO ProjectAssignedTable(PA_ID,Pro_ID,E_ID)
VALUES (3,3,3);

INSERT INTO ProjectAssignedTable(PA_ID,Pro_ID,E_ID)
VALUES (4,4,4);

INSERT INTO ProjectAssignedTable(PA_ID,Pro_ID,E_ID)
VALUES (5,5,5);

SET IDENTITY_INSERT dbo.ProjectAssignedTable OFF; 

-----------------------------------------------------------
SET IDENTITY_INSERT dbo.TestedByTable ON;  

INSERT INTO TestedByTable(Test_ID,Pro_ID,E_ID)
VALUES (1,1,1);

INSERT INTO TestedByTable(Test_ID,Pro_ID,E_ID)
VALUES (2,2,2);

INSERT INTO TestedByTable(Test_ID,Pro_ID,E_ID)
VALUES (3,3,3);

INSERT INTO TestedByTable(Test_ID,Pro_ID,E_ID)
VALUES (4,4,4);

INSERT INTO TestedByTable(Test_ID,Pro_ID,E_ID)
VALUES (5,5,5);

SET IDENTITY_INSERT dbo.TestedByTable OFF;

----------------------------------------------------

SET IDENTITY_INSERT dbo.projectIncomeTable ON;  

INSERT INTO projectIncomeTable(PI_ID,Project_id,Amount,Note,Date)
VALUES (1,1,'10000','good feedback','2020-01-01');

INSERT INTO projectIncomeTable(PI_ID,Project_id,Amount,Note,Date)
VALUES (2,2,'20000','good','2020-02-02');

INSERT INTO projectIncomeTable(PI_ID,Project_id,Amount,Note,Date)
VALUES (3,3,'30000','normal feedback','2020-03-03');

INSERT INTO projectIncomeTable(PI_ID,Project_id,Amount,Note,Date)
VALUES (4,4,'40000','fair','2020-04-04');

INSERT INTO projectIncomeTable(PI_ID,Project_id,Amount,Note,Date)
VALUES (5,5,'50000','good','2020-05-05');

SET IDENTITY_INSERT dbo.projectIncomeTable OFF;

------------------------------------------------------
SET IDENTITY_INSERT dbo.Regular_Expenses ON;  

INSERT INTO Regular_Expenses(RE_ID,Amount,Description,Date)
VALUES (1,'10000','samosas','2020-01-01');

INSERT INTO Regular_Expenses(RE_ID,Amount,Description,Date)
VALUES (2,'20000','biryani','2020-02-02');

INSERT INTO Regular_Expenses(RE_ID,Amount,Description,Date)
VALUES (3,'30000','korma','2020-03-03');

INSERT INTO Regular_Expenses(RE_ID,Amount,Description,Date)
VALUES (4,'40000','pizza','2020-04-04');

INSERT INTO Regular_Expenses(RE_ID,Amount,Description,Date)
VALUES (5,'50000','lobia','2020-05-05');

SET IDENTITY_INSERT dbo.Regular_Expenses OFF;
-------------------------------------------------------------
SET IDENTITY_INSERT dbo.ProjectExpense ON;  

INSERT INTO ProjectExpense(PE_ID,Pro_ID,E_ID,Amount,Date,Note)
VALUES (1,1,1,'10000','2020-01-01','hardware');

INSERT INTO ProjectExpense(PE_ID,Pro_ID,E_ID,Amount,Date,Note)
VALUES (2,2,2,'20000','2020-02-02','net pkg');

INSERT INTO ProjectExpense(PE_ID,Pro_ID,E_ID,Amount,Date,Note)
VALUES (3,3,3,'30000','2020-03-03','printer');

INSERT INTO ProjectExpense(PE_ID,Pro_ID,E_ID,Amount,Date,Note)
VALUES (4,4,4,'40000','2020-04-04','table');

INSERT INTO ProjectExpense(PE_ID,Pro_ID,E_ID,Amount,Date,Note)
VALUES (5,5,5,'50000','2020-05-05','employe fee');

SET IDENTITY_INSERT dbo.ProjectExpense OFF;
---------------------------------------------------------
SET IDENTITY_INSERT dbo.Employee_Salaries ON;  

INSERT INTO Employee_Salaries(ES_ID,E_ID,Amount,Date,Note)
VALUES (1,1,'10000','2020-01-01','hardware');

INSERT INTO Employee_Salaries(ES_ID,E_ID,Amount,Date,Note)
VALUES (2,2,'20000','2020-02-02','net pkg');

INSERT INTO Employee_Salaries(ES_ID,E_ID,Amount,Date,Note)
VALUES (3,3,'30000','2020-03-03','printer');

INSERT INTO Employee_Salaries(ES_ID,E_ID,Amount,Date,Note)
VALUES (4,4,'40000','2020-04-04','table');

INSERT INTO Employee_Salaries(ES_ID,E_ID,Amount,Date,Note)
VALUES (5,5,'50000','2020-05-05','employe fee');

SET IDENTITY_INSERT dbo.Employee_Salaries OFF;
---------------------------------------------------------
SET IDENTITY_INSERT dbo.StudentsTable ON;  

INSERT INTO StudentsTable(Std_ID,Name)
VALUES (1,'ali');

INSERT INTO StudentsTable(Std_ID,Name)
VALUES (2,'khan');

INSERT INTO StudentsTable(Std_ID,Name)
VALUES (3,'bilal');

INSERT INTO StudentsTable(Std_ID,Name)
VALUES (4,'mubashir');

INSERT INTO StudentsTable(Std_ID,Name)
VALUES (5,'haris');

SET IDENTITY_INSERT dbo.StudentsTable OFF;
--------------------------------------------------------
SET IDENTITY_INSERT dbo.AcademyIncomeTable ON;  

INSERT INTO AcademyIncomeTable(AI_ID,Std_ID,Amount,Note,Date)
VALUES (1,1,'10000','student fee','2020-01-01');

INSERT INTO AcademyIncomeTable(AI_ID,Std_ID,Amount,Note,Date)
VALUES (2,2,'20000','cash award','2020-02-02');

INSERT INTO AcademyIncomeTable(AI_ID,Std_ID,Amount,Note,Date)
VALUES (3,3,'30000','tution fee','2020-03-03');

INSERT INTO AcademyIncomeTable(AI_ID,Std_ID,Amount,Note,Date)
VALUES (4,4,'40000','freelancing','2020-04-04');

INSERT INTO AcademyIncomeTable(AI_ID,Std_ID,Amount,Note,Date)
VALUES (5,5,'50000','bonus','2020-05-05');

SET IDENTITY_INSERT dbo.AcademyIncomeTable OFF;
---------------------------------------------------
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
SET IDENTITY_INSERT dbo.AttendanceTable ON;  

INSERT INTO AttendanceTable(Att_ID,E_ID,Date,InTime,OutTime,State_ID)
VALUES (1,1,'2020-01-01','11:00:00','6:00:00',1);

INSERT INTO AttendanceTable(Att_ID,E_ID,Date,InTime,OutTime,State_ID)
VALUES (2,2,'2020-02-02','00:00:00','00:00:00',2);

INSERT INTO AttendanceTable(Att_ID,E_ID,Date,InTime,OutTime,State_ID)
VALUES (3,3,'2020-03-03','00:00:00','00:00:00',3);

INSERT INTO AttendanceTable(Att_ID,E_ID,Date,InTime,OutTime,State_ID)
VALUES (4,4,'2020-04-04','12:00:00','6:00:00',4);

INSERT INTO AttendanceTable(Att_ID,E_ID,Date,InTime,OutTime,State_ID)
VALUES (5,5,'2020-05-05','11:00:00','6:00:00',3);

SET IDENTITY_INSERT dbo.AttendanceTable OFF;

--------------------------------------------------------
SET IDENTITY_INSERT dbo.Withdrawal ON;  

INSERT INTO Withdrawal(WithdrawalID,Name,Date,Amount,Note)
VALUES (1,'basit','2020-01-01','10','for samosa');

INSERT INTO Withdrawal(WithdrawalID,Name,Date,Amount,Note)
VALUES (2,'haris','2020-02-02','100','for tea');

INSERT INTO Withdrawal(WithdrawalID,Name,Date,Amount,Note)
VALUES (3,'ali','2020-03-03','1000','for drink');

INSERT INTO Withdrawal(WithdrawalID,Name,Date,Amount,Note)
VALUES (4,'mesum','2020-04-04','10000','employee dress');

INSERT INTO Withdrawal(WithdrawalID,Name,Date,Amount,Note)
VALUES (5,'waqar','2020-05-05','100000','for biscut');

SET IDENTITY_INSERT dbo.Withdrawal OFF;
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
SET IDENTITY_INSERT dbo.LoginInfoTable ON;  

INSERT INTO LoginInfoTable(L_ID,Username,Password,Role_ID)
VALUES (1,'basit','123',1);

INSERT INTO LoginInfoTable(L_ID,Username,Password,Role_ID)
VALUES (2,'talha','123',2);

INSERT INTO LoginInfoTable(L_ID,Username,Password,Role_ID)
VALUES (3,'hairs','123',3);

SET IDENTITY_INSERT dbo.LoginInfoTable OFF;

