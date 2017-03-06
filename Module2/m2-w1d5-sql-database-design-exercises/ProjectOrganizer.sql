/* 
 Assumptions about the data
 Projects are associated not directly associated with particular departments.  
 If the client wanted projects assoicated with departments, 
 I would probably add an additional column to the projects database that was deparment number
 It would be a foreign key from the deparments table
 
 Answers to questions -
1) Is a natural key available for the primary key, or will you need a surrogate?
	I would think that we would want to make surgate keys for most of the tables.  
	I would not want to use social security for employees for privacy issues.

2) What data type should be used for each column?
	I mainly used, integer, varchar and date.

3) What attribues are required? Which are optional?
	In my tables the only thing that is not required is the start date for projects.
	I figured that there could be potential times where we could identify a potential project
	without having all of the specifics figured out as to when we would start it.

4) Are there additional constraints such as length, data format, or restricted values for any columns?
	I put some restrictions on length for the varchar and set all the dates to the date format.
	I could put additional constraints on some of the date fields but that would require additional
	reasoning as to whether they are necessary.  But something like they have to be after 1900
	and that the employee would have to be at least 18 years old to work for us, etc..

5) What table columns will the user likely search?
	I figured the user will probably search the project_employee table joined with employee to 
	find out who all is on a particular project.  They could also join it with the department
	table to find out which departments are working on a particular project.
	I figured the would search the employee table to find out who is in particular departments.
	It was not in the requirement but I would probably but things like - street address, 
	city, county, state, phone number, emergency contact, emergency contact phone number, 
	spouse, dependents, preferred hospital, etc... in the employee table so that 
	if an emergency would arise we would know who to contact.
	 
6) Is there an official list of valid job titles?
    I am assuming that the job titles are specific and do not duplicate across deparments
	If every departmnet had the same titles say - Manager, Director, Chief Officer, Analysts, etc -
	then I would put the title name/description and title id in their own table -
	with the title id as the primary key and use the title id in employee table as a foreign key.

create database ProjectOrganizer;

*/
Begin Transaction
create table departments (
	number integer identity(1,1) not null,
	name   varchar(50) not null,
	constraint pk_departments primary key (number)
	);

create table projects (
	number integer identity(1,1) not null,
	name   varchar(50) not null,
	start_date date,
	constraint pk_number primary key (number)
	);

create table employee (
	number integer identity(1,1) not null,
	last_name varchar(50) not null,
	first_name varchar(50) not null,
	gender varchar(6) not null,
	birthday date not null,
	hiredate date not null,
	department_number integer not null,
	jobtitle varchar(50) not null,
	constraint ck_gender check (gender in ('male', 'female')),
	constraint pk_employee primary key (number),
	constraint fk_employee_deparment_number foreign key (department_number) references departments(number)
);

create table project_employee(
	project_number integer not null,
	employee_number integer not null,
	constraint pk_project_employee primary key nonclustered (project_number, employee_number),
	constraint fk_project_project_number foreign key (project_number) references projects(number),
	constraint fk_project_employee_number foreign key (employee_number) references employee(number)	
);

insert into projects (name, start_date) values 
		('Retain Wonderful Employees', '12/1/17'),
		('Target Great Customers', '11/2/16'),
		('Build a Better Widget', '3/12/19'),
		('Build a Quicker MouseTrap', '5/5/15'),
		('World Dominance', '6/7/20');

insert into departments (name) values
		('Finance'),
		('Billing'),
		('Marketing'),
		('Sales');

insert into employee(last_name, first_name, gender, birthday, hiredate, jobtitle, department_number) values
		('Zenith','Amy','female','12/15/70','2/3/12','Director',1),
		('Yonkers','Gary','male','11/27/69','3/6/13','Analyst',1),
		('Williams','Barbara','female','10/15/79','4/5/14','Team Lead',1),
		('Undersmite','Frank','male','9/15/89','5/6/15','Accounts Payable Specialist',2),
		('Voltaire','Cathy','female','8/10/99','6/7/16','Bookkeeper',2),
		('Reginald','Ethan','male','7/5/95','8/8/17','Accounts Receivable Specialist',2),
		('Thompson','Diana','female','6/1/85','1/2/11','Community Liason',3),
		('Smith','Harry','male','5/30/75','9/10/10','Promoter',3),
		('Peebles','Jamie','female','4/26/65','11/11/09','Public Relations Specialists',3),
		('Quaker','Ian','male','3/21/59','12/12/08','Sales Generator',4),
		('Xenith','Lisa','female','2/16/55','12/20/07','Team Member',4),
		('Oreily','Matthew','male','1/11/49','11/28/06','Customer Relations Specialist',4);

insert into project_employee (project_number, employee_number) values
		(1,12), 
		(1,9),
		(1,6),
		(2,3),
		(2,11),
		(2,5),
		(3,2),
		(3,10),
		(3,4),
		(3,1),
		(4,12),
		(4,8),
		(4,4),
		(5,11),
		(5,7),
		(5,3);
commit;
