create table Victim(
	VictimID int identity(1,1) primary key,
	IDCard int,
	Name varchar(30),
	VictimAddress varchar(50),
	PhoneNumber int,
	CaseNumber int,
)

create table Officers(
	officerID int identity(1,1) primary key,
	officerName varchar(50),
	officerRank varchar(20),
	officerSalary int,
	officerAddress varchar(50),
	officerPhoneNo bigint,
	officerAge int,
	officerJoiningDate varchar(20),
	officerCNIC bigint
)