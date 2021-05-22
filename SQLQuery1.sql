create table Victim(
	ID int identity(1,1) primary key,
	IDCard bigint unique,
	Name varchar(30),
	VictimAddress varchar(50),
	PhoneNumber int,
	CaseNumber int not null,
)

create table Officers(
	officerID int identity(1,1) primary key,
	officerName varchar(50),
	officerRank varchar(20),
	officerSalary int,
	officerAddress varchar(50),
	officerPhoneNo bigint not null,
	officerAge int,
	officerJoiningDate varchar(20),
	officerCNIC bigint unique
)

create table Criminals(
	criminalID int identity(1,1) Primary Key,
	name varchar(30),
    Age int check (Age>0),
    criminalAddress varchar(40),
    dateOfArrest varchar(40),
    batchID int,
    crimeID int,
    caseNo int
)

create table cases(
	caseID int primary key identity(1,1),
	startingDate varchar(20),
	endingDate varchar(20),
	caseType varchar(20),
	solved varchar(20) not null,
	officerBatchID int,
	crimeID int,
	victimID int 
);
create table crime(
	crimeID int primary key identity(1,1),
	crimeType varchar(35),
	crimeDate varchar(25),
	location varchar(50) not null,
	noOfPeopleArrest int
);
drop table Victim