
-- 创建[LearningRecordExcel].[Department]表，并初始化数据；
if not exists (select * from sysobjects where name = 'Department')
begin
CREATE TABLE [Department](
	[DepartmentName] [varchar](50) NOT NULL PRIMARY KEY,
	[CreatedDate] [datetime] NULL,
	[UpdatedDate] [datetime] NULL
) 

-- 初始化数据
insert into [department](departmentName,CreatedDate,UpdatedDate) values('Central',GETDATE(),GETDATE());
insert into [department](departmentName,CreatedDate,UpdatedDate) values('Channel Sales',GETDATE(),GETDATE());
insert into [department](departmentName,CreatedDate,UpdatedDate) values('Hong Kong',GETDATE(),GETDATE());
insert into [department](departmentName,CreatedDate,UpdatedDate) values('North',GETDATE(),GETDATE());
insert into [department](departmentName,CreatedDate,UpdatedDate) values('South',GETDATE(),GETDATE());
insert into [department](departmentName,CreatedDate,UpdatedDate) values('Taiwan',GETDATE(),GETDATE());
insert into [department](departmentName,CreatedDate,UpdatedDate) values('Services',GETDATE(),GETDATE());
insert into [department](departmentName,CreatedDate,UpdatedDate) values('DI Comm Ops',GETDATE(),GETDATE());
insert into [department](departmentName,CreatedDate,UpdatedDate) values('CT',GETDATE(),GETDATE());
insert into [department](departmentName,CreatedDate,UpdatedDate) values('Enterprise',GETDATE(),GETDATE());
insert into [department](departmentName,CreatedDate,UpdatedDate) values('FI',GETDATE(),GETDATE());
insert into [department](departmentName,CreatedDate,UpdatedDate) values('Govt Loans',GETDATE(),GETDATE());
insert into [department](departmentName,CreatedDate,UpdatedDate) values('ICS',GETDATE(),GETDATE());
insert into [department](departmentName,CreatedDate,UpdatedDate) values('MR',GETDATE(),GETDATE());
insert into [department](departmentName,CreatedDate,UpdatedDate) values('Marketing',GETDATE(),GETDATE());
insert into [department](departmentName,CreatedDate,UpdatedDate) values('Pricing',GETDATE(),GETDATE());
insert into [department](departmentName,CreatedDate,UpdatedDate) values('Xray',GETDATE(),GETDATE());
insert into [department](departmentName,CreatedDate,UpdatedDate) values('CS Sales',GETDATE(),GETDATE());
insert into [department](departmentName,CreatedDate,UpdatedDate) values('Lift Support Sys',GETDATE(),GETDATE());
insert into [department](departmentName,CreatedDate,UpdatedDate) values('Monitoring',GETDATE(),GETDATE());
insert into [department](departmentName,CreatedDate,UpdatedDate) values('Ultrasound',GETDATE(),GETDATE());
insert into [department](departmentName,CreatedDate,UpdatedDate) values('Healthcare IT',GETDATE(),GETDATE());
insert into [department](departmentName,CreatedDate,UpdatedDate) values('LS',GETDATE(),GETDATE());
insert into [department](departmentName,CreatedDate,UpdatedDate) values('MD',GETDATE(),GETDATE());
insert into [department](departmentName,CreatedDate,UpdatedDate) values('BD',GETDATE(),GETDATE());
insert into [department](departmentName,CreatedDate,UpdatedDate) values('Communications',GETDATE(),GETDATE());
insert into [department](departmentName,CreatedDate,UpdatedDate) values('Finance',GETDATE(),GETDATE());
insert into [department](departmentName,CreatedDate,UpdatedDate) values('HR',GETDATE(),GETDATE());
insert into [department](departmentName,CreatedDate,UpdatedDate) values('IT',GETDATE(),GETDATE());
insert into [department](departmentName,CreatedDate,UpdatedDate) values('Lean Six Sigma',GETDATE(),GETDATE());
insert into [department](departmentName,CreatedDate,UpdatedDate) values('Legal & Compliance',GETDATE(),GETDATE());
insert into [department](departmentName,CreatedDate,UpdatedDate) values('OTR',GETDATE(),GETDATE());
insert into [department](departmentName,CreatedDate,UpdatedDate) values('QA/RA',GETDATE(),GETDATE());
insert into [department](departmentName,CreatedDate,UpdatedDate) values('STO',GETDATE(),GETDATE());
insert into [department](departmentName,CreatedDate,UpdatedDate) values('Sourcing',GETDATE(),GETDATE());
insert into [department](departmentName,CreatedDate,UpdatedDate) values('MD Plant',GETDATE(),GETDATE());
insert into [department](departmentName,CreatedDate,UpdatedDate) values('GPRS',GETDATE(),GETDATE());
insert into [department](departmentName,CreatedDate,UpdatedDate) values('GSC',GETDATE(),GETDATE());
end
GO
