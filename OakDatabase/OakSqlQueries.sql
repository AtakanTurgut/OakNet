/* insert into TableName Column(Column_Name) values (Column_Values) */
insert into Persons (Name,Surname,JobId) values ('Talat', 'Necali', 3)
insert into Jobs (JobName) values ('Fireman')

/* select Column_Name from Table_Name */
select * from Persons
select * from Jobs

select * from Persons where Name = 'Fatih' 
select ps.Name, ps.Surname, j.JobName from Persons ps, Jobs j where ps.JobId = j.Id and j.JobName = 'Teacher'

/* update Table_Name set column1=value1, column2=value2 where condition */
update Persons set Name = 'Cihangir' where Name = 'Talat'

/* delete from Table_Name where condition */
delete from Persons where Surname = 'Necali'