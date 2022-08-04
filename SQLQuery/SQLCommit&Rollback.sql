--Commit and RollBack


select * from student;

begin try
      begin tran
	  insert into student values (3,'Rupesh',98,101);
	  insert into student values (4,'Ajinkya',96,102);
	  commit tran;
	  end try
begin catch
      select ERROR_MESSAGE();
	  rollback tran;
	  end catch;
