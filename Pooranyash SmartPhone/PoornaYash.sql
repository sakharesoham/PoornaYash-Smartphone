create database PoornaYash

use PoornaYash

create table Registration
(
RegID bigint identity(1,1),
RegUsername nvarchar(200),
RegPassword nvarchar(200)
)

select * from Registration
drop table Registration

create procedure Pro_InsertRegistration
(
@RegID bigint=0,
@RegUsername nvarchar(200),
@RegPassword nvarchar(200),
@RegTransactionId int
)
as
begin
if @RegTransactionId=1
begin
insert into Registration(RegUsername,RegPassword) values (@RegUsername,@RegPassword)
end

if @RegTransactionId=2
begin
update Registration set RegUsername=@RegUsername,RegPassword=@RegPassword 
where RegID=@RegID
end
end
 
create table tblBrand
(
BrandID bigint identity(1,1),
BrandName nvarchar(200) 
 )
 
 select * from tblBrand;
 drop table tblBrand
create procedure Pro_InsertUpdateBrand
(
@BrandID bigint=0,
@BrandName nvarchar(200), 
@BrandTransactionId int
)

as
begin
if @BrandTransactionId=1
begin
insert into tblBrand (BrandName) values(@BrandName)
end

if @BrandTransactionId=2
begin
update tblBrand set BrandName=@BrandName
where BrandID=@BrandID
end
end

alter procedure Pro_BrandName
as
begin
select BrandName from tblBrand
end

alter procedure Pro_FetchBrandID(@BrandName nvarchar(200))
as 
begin
select BrandID from tblBrand where BrandName=@BrandName
end


create table tblColor
(
ColorID bigint identity(1,1),
ColorName nvarchar(200) 
 )
 
 select * from tblColor;

 drop table tblColor
 
create procedure Pro_InsertUpdateColor
(
@ColorID bigint=0,
@ColorName nvarchar(200), 
@ColorTransactionId int
)

as
begin
if @ColorTransactionId=1
begin
insert into tblColor (ColorName) values(@ColorName)
end

if @ColorTransactionId=2
begin
update tblColor set ColorName=@ColorName
where ColorID=@ColorID
end
end

alter procedure Pro_ColorName
as
begin
select ColorName from tblColor
end

alter procedure Pro_FetchColorID(@ColorName nvarchar(200))
as 
begin
select ColorID from tblColor where ColorName=@ColorName
end


create table tblGST
(
GSTID bigint identity(1,1),
GST nvarchar(200),
SGST nvarchar(200),
CGST nvarchar(200)
)

select * from tblGST;
drop table tblGST

create procedure Pro_InsertUpdateGST
(
@GSTID bigint=0,
@GST nvarchar(200),
@SGST nvarchar(200),
@CGST nvarchar(200),
@GSTTransactionId int
)

as
begin
if @GSTTransactionId=1
begin
insert into tblGST (GST,SGST,CGST) values(@GST,@SGST,@CGST)
end

if @GSTTransactionId=2
 begin
 update tblGST set GST=@GST,SGST=@SGST,CGST=@CGST
 where GSTID=@GSTID
 end
 end
 
 create procedure Pro_GSTFetch
as
begin
select GST from tblGST
end

create procedure Pro_FetchIDGST(@GST bigint)
as 
begin
select SGST,CGST from tblGST where GST=@GST
end

 
 create table tblBank
 (
 BankID bigint identity(1,1),
 BankAccountNo bigint,
 AccountHolderName nvarchar(200),
 BankName nvarchar(200),
 BranchAddress nvarchar(200),
 OpeningBalance bigint,
 IFSC nvarchar(200),
 MICR bigint
 )
 
 select * from tblBank
 delete from tblBank where BankID<100;
 drop table tblBank
 
alter procedure Pro_insertupdateBank
(
 @BankID bigint=0,
 @BankAccountNo bigint,
 @AccountHolderName nvarchar(200),
 @BankName nvarchar(200),
 @BranchAddress nvarchar(200),
 @OpeningBalance bigint,
 @IFSC nvarchar(200),
 @MICR bigint,
@BankTransactionId int
) 

as
begin
if @BankTransactionId=1
begin
insert into tblBank (BankAccountNo,AccountHolderName,BankName,BranchAddress,OpeningBalance,IFSC,MICR) 
values(@BankAccountNo,@AccountHolderName,@BankName,@BranchAddress,@OpeningBalance,@IFSC,@MICR)
end

if @BankTransactionId=2
begin
update tblBank set BankAccountNo=@BankAccountNo,AccountHolderName=@AccountHolderName,BankName=@BankName,BranchAddress=@BranchAddress,OpeningBalance=@OpeningBalance,IFSC=@IFSC,MICR=@MICR
where BankID=@BankID
end
end


create procedure Pro_fetchBank
as
begin
select BankAccountNo from tblBank
end

create procedure Pro_FetchBankID(@BankAccountNo bigint)
as
begin
select BankID from tblBank where BankAccountNo=@BankAccountNo
end



create table tblincome
(
IncomeID bigint identity(1,1),
Income nvarchar(200)
)
drop table tblincome

select * from tblincome

alter procedure Pro_InsertIncome
(
@IncomeID bigint=0,
@Income nvarchar(200),
@IncometransactionId int
)

as
begin
if @IncometransactionId=1
begin
insert into tblincome (Income) values(@Income)
end

end

create procedure Pro_fetchIncome
as
begin
select Income from tblincome
end

create procedure Pro_FetchIncomeID(@Income nvarchar(200))
as
begin
select IncomeID from tblincome where Income=@Income
end

create table Incomedetails
(
IncomedetailsID bigint identity(1,1),
IncomeExpense nvarchar(200),
IncomeExpensetype nvarchar(200)
)
drop table Incomedetails
select * from Incomedetails

create procedure Pro_InsertIncomeType
(
@IncomedetailsID bigint=0,
@IncomeExpense nvarchar(200),
@IncomeExpensetype nvarchar(200),
@IncomeTransact int
)

as
begin
if @IncomeTransact=1
begin
insert into Incomedetails(IncomeExpense,IncomeExpensetype) values(@IncomeExpense,@IncomeExpensetype)
end
end

create table Recharge
(
RechargeID bigint identity(1,1),
RechargeCompany nvarchar(200)
)
select * from Recharge;


create procedure Pro_InsertRecharge
(
@RechargeID bigint=0,
@RechargeCompany nvarchar(200),
@RechargeTransactionId int
)

as
begin
if @RechargeTransactionId=1
begin
insert into Recharge(RechargeCompany) values(@RechargeCompany)
end

if @RechargeTransactionId=2
begin
update Recharge set RechargeCompany=@RechargeCompany
where RechargeID=@RechargeID
end
end

create table Supplier
(
SupplierID bigint identity(1,1),
SupplierName nvarchar(200),
Addresss nvarchar(200),
ContactNo bigint,
AltContact bigint,
GSTIN nvarchar(200),
BankAccNo bigint,
BankName nvarchar(200),
IFSC nvarchar(200),
MICR nvarchar(200),
OpeningBalance bigint
)
drop table Supplier
select * from Supplier;

create procedure Pro_InsertUpdateSupplier
(
@SupplierID bigint=0,
@SupplierName nvarchar(200),
@Addresss nvarchar(200),
@ContactNo bigint,
@AltContact bigint,
@GSTIN nvarchar(200),
@BankAccNo bigint,
@BankName nvarchar(200),
@IFSC nvarchar(200),
@MICR nvarchar(200),
@OpeningBalance bigint,
@SupplierTransactionId int
)

as
begin
if @SupplierTransactionId=1
begin
insert into Supplier (SupplierName,Addresss,ContactNo,AltContact,GSTIN,BankAccNo,BankName,IFSC,MICR,OpeningBalance)
values (@SupplierName,@Addresss,@ContactNo,@AltContact,@GSTIN,@BankAccNo,@BankName,@IFSC,@MICR,@OpeningBalance)
end

if @SupplierTransactionId=2
begin
update Supplier set SupplierName=@SupplierName,Addresss=@Addresss,ContactNo=@ContactNo,AltContact=@AltContact,
GSTIN=@GSTIN,BankAccNo=@BankAccNo,BankName=@BankName,IFSC=@IFSC,MICR=@MICR,OpeningBalance=@OpeningBalance
where SupplierId=@SupplierID
end
end


create procedure Pro_FetchSupplier
as
begin
select SupplierName from Supplier
end

create procedure Pro_FetchSupplierID(@SupplierName nvarchar(200))
as 
begin
select SupplierID from Supplier where SupplierName=@SupplierName
end

create table ProductDetails
(
ProductID bigint identity(1,1),
ProductName nvarchar(200),
BrandName nvarchar(200),
HSNCode bigint,
ColorID bigint,
StockLimit bigint,
Quantity bigint,
PurchaseRate bigint,
SalePrice bigint,
MRP bigint,
MOP bigint,
TotalGST bigint,
CGST bigint,
SGST bigint
)

drop table ProductDetails
delete from ProductDetails where ProductID<100;
select * from ProductDetails

create procedure Pro_InsertProduct
(
@ProductID bigint=0,
@ProductName nvarchar(200),
@BrandName nvarchar(200),
@HSNCode bigint,
@ColorID bigint,
@StockLimit bigint,
@Quantity bigint,
@PurchaseRate bigint,
@SalePrice bigint,
@MRP bigint,
@MOP bigint,
@TotalGST bigint,
@CGST bigint,
@SGST bigint,
@TransProduct int
)

as
begin
if @TransProduct=1
begin
insert into ProductDetails
(
ProductName ,
BrandName,
HSNCode ,
ColorID ,
StockLimit ,
Quantity ,
PurchaseRate,
SalePrice ,
MRP ,
MOP,
TotalGST ,
CGST,
SGST
) 
values 
(
@ProductName ,
@BrandName,
@HSNCode ,
@ColorID ,
@StockLimit ,
@Quantity ,
@PurchaseRate,
@SalePrice ,
@MRP ,
@MOP,
@TotalGST ,
@CGST,
@SGST
)
end
end

create procedure Pro_FetchProduct
as
begin
select ProductName from ProductDetails
end

create procedure Pro_FetchProductID(@ProductName nvarchar(200))
as 
begin
select ProductID from ProductDetails where ProductName=@ProductName
end

create table tblIMEI
(
IMEI_ID bigint identity(1,1),
IMEI1 bigint,
IMEI2 bigint
)

select * from tblIMEI;

create procedure Pro_InsertIMEI
(
@IMEI_ID bigint=0,
@IMEI1 bigint,
@IMEI2 bigint,
@IMEITransactionId int
)

as
begin
if @IMEITransactionId=1
begin
insert into tblIMEI (IMEI1,IMEI2) values(@IMEI1,@IMEI2)
end

if @IMEITransactionId=2
begin
update tblIMEI set IMEI1=@IMEI1,IMEI2=@IMEI2
where IMEI_ID=@IMEI_ID
end
end
 
 create procedure Pro_FetchIMEI
as
begin
select IMEI1 from tblIMEI
end

alter procedure Pro_FetchIMEIID(@IMEI1 bigint)
as 
begin
select IMEI_ID from tblIMEI where IMEI1=@IMEI1
end

 create procedure Pro_FetchIMEI2
as
begin
select IMEI2 from tblIMEI
end

alter procedure Pro_FetchIMEIID2(@IMEI2 bigint)
as 
begin
select IMEI_ID from tblIMEI where IMEI2=@IMEI2
end

create table tblSale
(
SaleID bigint identity(1,1),
IMEI_ID bigint,
InvoiceNo bigint,
CustomerName nvarchar(200),
ContactNo bigint,
ProductName nvarchar(200),
IMEI1 bigint,
IMEI2 bigint,
Sale bigint,
GST bigint,
Quantity bigint,
Amount bigint,
TotalAmount bigint
)
select * from tblSale;

drop table tblSale

delete from tblSale where SaleID=1;

alter procedure Pro_InsertSale
(
@SaleID bigint=0,
@IMEI_ID bigint=0,
@InvoiceNo bigint,
@CustomerName nvarchar(200),
@ContactNo bigint,
@ProductName nvarchar(200),
@IMEI1 bigint,
@IMEI2 bigint,
@Sale bigint,
@GST bigint,
@Quantity bigint,
@Amount bigint,
@TotalAmount bigint,
@SaleTransactionId int
)

as
begin
if @SaleTransactionId=1
begin
insert into tblSale (InvoiceNo,CustomerName,ContactNo,ProductName,IMEI1,IMEI2,Sale,GST,Quantity,Amount,TotalAmount) values(@InvoiceNo,@CustomerName,@ContactNo,@ProductName,@IMEI1,@IMEI2,@Sale,@GST,@Quantity,@Amount,@TotalAmount)
end

if @SaleTransactionId=2
begin
update tblSale set InvoiceNo=@InvoiceNo,@CustomerName=CustomerName,@ContactNo=ContactNo,@ProductName=ProductName,@IMEI1=IMEI1,@IMEI2=IMEI2,@Sale=Sale,@GST=GST,@Quantity=Quantity,@Amount=Amount,@TotalAmount=TotalAmount
where SaleID=@SaleID
end
end

create table BankTransaction
(
BankTrID bigint identity(1,1),
BankAccNo bigint,
BankName nvarchar(200),
Balance bigint,
Deposit nvarchar(200),
Amount bigint,
Narration nvarchar(200)
)

select * from BankTransaction

delete from BankTransaction where BankTrID<1000;

create procedure Pro_BankInsert
(
@BankTrID bigint=0,
@BankAccNo bigint,
@BankName nvarchar(200),
@Balance bigint,
@Deposit nvarchar(200),
@Amount bigint,
@Narration nvarchar(200),
@TransactionId int
)

as
begin
if @TransactionId=1
begin
insert into BankTransaction (BankAccNo,BankName,Balance,Deposit,Amount,Narration) values(@BankAccNo,@BankName,@Balance,@Deposit,@Amount,@Narration)
end
end

create table tblDeposit
(
DepositID bigint identity(1,1),
Deposit nvarchar(200)
)

select * from tblDeposit
drop table tblDeposit

alter procedure Pro_InsertDeposit
(
@DepositID bigint=0,
@Deposit nvarchar(200),
@DepositTransId int
)

as
begin
if @DepositTransId=1
begin
insert into tblDeposit (Deposit) values(@Deposit)
end
end

alter procedure Pro_FetchDeposit
as
begin
select Deposit from tblDeposit 
end
 
 create procedure Pro_FetchDepositID(@Deposit nvarchar)
as 
begin
select DepositID from tblDeposit where Deposit=@Deposit
end

create table Purchase
(
PurchaseID bigint identity(1,1),
InvoiceNo bigint,
SupplierName nvarchar(200),
ProductName nvarchar(200),
GSTIN nvarchar(200),
PurchaseRate bigint,
SaleRate bigint,
GSTRate bigint,
Quantity bigint,
Amount bigint,
TotalAmount bigint
)

select * from Purchase;
drop table Purchase
alter procedure Pro_InsertPurchase
(
@PurchaseID bigint=0,
@InvoiceNo bigint,
@SupplierName nvarchar(200),
@ProductName nvarchar(200),
@GSTIN nvarchar(200),
@PurchaseRate bigint,
@SaleRate bigint,
@GSTRate bigint,
@Quantity bigint,
@Amount bigint,
@TotalAmount bigint,
@PurchaseTransaction int
)

as
begin
if @PurchaseTransaction=1
begin
insert into Purchase(InvoiceNo,SupplierName,ProductName,GSTIN,PurchaseRate,SaleRate,GSTRate,Quantity,Amount,TotalAmount)
values (@InvoiceNo,@SupplierName,@ProductName,@GSTIN,@PurchaseRate,@SaleRate,@GSTRate,@Quantity,@Amount,@TotalAmount)
end
end

create table Employee
(
EmployeeID bigint identity(1,1),
JoiningDate date,
EmpID bigint,
Designation nvarchar(200),
Promotedby nvarchar(200),
NameofPerson nvarchar(200),
Addres nvarchar(200),
ContactNo bigint,
Gender nvarchar(200),
Qualification nvarchar(200),
salary bigint,
PF bigint,
ReferenceDetails nvarchar(200),
idproof nvarchar(300),
idimage nvarchar(300)
)

select * from Employee
drop table Employee
delete from Employee where EmployeeID=15;

alter procedure Pro_Employeeinsert
(
@EmployeeID bigint=0,
@JoiningDate date,
@EmpID bigint,
@Designation nvarchar(200),
@Promotedby nvarchar(200),
@NameofPerson nvarchar(200),
@Addres nvarchar(200),
@ContactNo bigint,
@Gender nvarchar(200),
@Qualification nvarchar(200),
@salary bigint,
@PF bigint,
@ReferenceDetails nvarchar(200),
@idproof nvarchar(300),
@idimage nvarchar(300),
@EmpTransactionId int
)

as
begin
if @EmpTransactionId=1
begin 
insert into Employee(JoiningDate,EmpID,Designation,Promotedby,NameofPerson,Addres,ContactNo,Gender,Qualification,salary,PF,ReferenceDetails,idproof,idimage)
values(@JoiningDate,@EmpID,@Designation,@Promotedby,@NameofPerson,@Addres,@ContactNo,@Gender,@Qualification,@salary,@PF,@ReferenceDetails,@idproof,@idimage)
end
end

create procedure Pro_FetchEmployeeName
as
begin
select NameofPerson from Employee
end;

alter procedure Pro_FetchEmployeeId(@NameofPerson nvarchar(200))
as
begin
select EmpID from Employee where NameofPerson=@NameofPerson
end

create table tblFirm
(
FirmId bigint identity(1,1),
FName nvarchar(200),
FAddress nvarchar(200),
FState nvarchar(200),
FCity nvarchar(200),
FPin bigint,
FGSTNo nvarchar(200),
FOwnerName nvarchar(200),
FMobile bigint,
FPAN nvarchar(200),
FMail nvarchar(200),
Firm nvarchar(300)
)

select * from tblFirm
drop table tblFirm

alter procedure Pro_StateInsert
(
@FirmId bigint=0,
@FName nvarchar(200),
@FAddress nvarchar(200),
@FState nvarchar(200),
@FCity nvarchar(200),
@FPin bigint,
@FGSTNo nvarchar(200),
@FOwnerName nvarchar(200),
@FMobile bigint,
@FPAN nvarchar(200),
@FMail nvarchar(200),
@FirmTransactionId int,
@Firm nvarchar(300)
)

as
begin
if @FirmTransactionId=1
begin
insert into tblFirm(FName,FAddress,FState,FCity,FPin,FGSTNo,FOwnerName,FMobile,FPAN,FMail,Firm) values (@FName,@FAddress,@FState,@FCity,@FPin,@FGSTNo,@FOwnerName,@FMobile,@FPAN,@FMail,@Firm)
end
end

create procedure Pro_FirmFetch
as
begin
select FName from tblFirm
end

create procedure Pro_FirmID(@FName nvarchar(200))
as
begin
select FirmId from tblFirm where FName=@FName
end

create table tblState
(
StateID bigint identity(1,1),
StateName nvarchar(200)
)

select * from tblState 

alter procedure Pro_StaeInsert
(
@StateID bigint=0,
@StateName nvarchar(200),
@StatetransactionId int
)

as
begin
if @StatetransactionId=1
begin
insert into tblState (StateName) values(@StateName)
end
end

create procedure Pro_FetchState
as
begin
select StateName from tblState
end

create procedure Pro_FetchStateID(@StateName nvarchar(200))
as
begin
select StateID from tblState where StateName=@StateName
end

create table AddExpenseName
(
ExpenseID bigint identity(1,1),
ExpenseType nvarchar(200),
ExpenseName nvarchar(200)
)

select * from AddExpenseName

create procedure Pro_InsertAddExpense
(
@ExpenseID bigint=0,
@ExpenseType nvarchar(200),
@ExpenseName nvarchar(200),
@TransAddExpense int
)

as
begin
if @TransAddExpense=1
begin
insert into AddExpenseName( ExpenseType,ExpenseName) values (@ExpenseType,@ExpenseName)
end
end

create table tblExpenses
(
ExpenseID bigint identity(1,1),
Daet date,
ExpenseorIncome nvarchar(200),
ExpenseName nvarchar(200),
Amount bigint,
PaymentMode nvarchar(200),
PaymentRef nvarchar(200),
Remark nvarchar(200)
)

select * from tblExpenses;

alter procedure Pro_ExpenseInsert
(
@ExpenseID bigint=0,
@Daet date,
@ExpenseorIncome nvarchar(200),
@ExpenseName nvarchar(200),
@Amount bigint,
@PaymentMode nvarchar(200),
@PaymentRef nvarchar(200),
@Remark nvarchar(200),
@ExpensTransactionId int
)

as
begin
if @ExpensTransactionId=1
begin
insert into tblExpenses(Daet,ExpenseorIncome,ExpenseName,Amount,PaymentMode,PaymentRef,Remark) values (@Daet,@ExpenseorIncome,@ExpenseName,@Amount,@PaymentMode,@PaymentRef,@Remark)
end

if @ExpensTransactionId=2
begin
delete from tblExpenses where ExpenseID=@ExpenseID
end
end

create table trial
(
trialid bigint identity(1,1),
idimage nvarchar(200),
picimage nvarchar(200)
)

select * from trial 

create procedure Pro_trialinsert
(
@trialid bigint=0,
@idimage nvarchar(200),
@picimage nvarchar(200),
@trialtrans int
)

as
begin
if @trialtrans=1
begin
insert into trial (idimage,picimage) values(@idimage,@picimage)
end
end

create table Attendance
(
AttendaceID bigint identity(1,1),
NameofPerson nvarchar(200),
ispresent bigint,
Date date
)

select * from Attendance 
drop table Attendance

alter procedure Pro_insertattend
(
@AttendaceID bigint=0,
@NameofPerson nvarchar(200),
@ispresent bigint,
@Date date,
@attendtransaction int
)
as
begin
if @attendtransaction=1
begin
insert into Attendance (NameofPerson,ispresent,Date) values(@NameofPerson,@ispresent,@Date)
end
end


create table tblDistributor
(
DistributorID bigint identity(1,1),
Datee date,
Disttype nvarchar(200),
BrandName nvarchar(200),
DistName nvarchar(200),
DistGST nvarchar(200),
DistContactName nvarchar(200),
DistContNo bigint,
DistAddress nvarchar(200),
DistState nvarchar(200),
DistCity nvarchar(200),
Distbank nvarchar(200),
DistAcc bigint,
DistIFSc nvarchar(200),
DistMicr nvarchar(200)
)

select * from tblDistributor

delete from tblDistributor where DistributorID=1

alter procedure Pro_InsertDistributor
(
@DistributorID bigint=0,
@Datee date,
@Disttype nvarchar(200),
@BrandName nvarchar(200),
@DistName nvarchar(200),
@DistGST nvarchar(200),
@DistContactName nvarchar(200),
@DistContNo bigint,
@DistAddress nvarchar(200),
@DistState nvarchar(200),
@DistCity nvarchar(200),
@Distbank nvarchar(200),
@DistAcc bigint,
@DistIFSc nvarchar(200),
@DistMicr nvarchar(200),
@DistTransactionId int
)

as
begin
if @DistTransactionId=1
begin
insert into tblDistributor(Datee,Disttype,BrandName,DistName,DistGST,DistContactName,DistContNo,DistAddress,DistState,DistCity,Distbank,DistAcc,DistIFSc,DistMicr)
values (@Datee,@Disttype,@BrandName,@DistName,@DistGST,@DistContactName,@DistContNo,@DistAddress,@DistState,@DistCity,@Distbank,@DistAcc,@DistIFSc,@DistMicr)
end
end

create procedure Pro_DistFetch
as
begin
select DistName from tblDistributor
end

create procedure Pro_FetchDistID(@DistName nvarchar(200))
as
begin
select DistributorID from tblDistributor where DistName=@DistName
end

create table tblEmpTransaction
(
EmpTransactionID bigint identity(1,1),
EmpName nvarchar(200),
PaymentStatus nvarchar(200),
Amount bigint
)

select * from tblEmpTransaction;

create procedure Pro_InsertEmpTransaction
(
@EmpTransactionID bigint=0,
@EmpName nvarchar(200),
@PaymentStatus nvarchar(200),
@Amount bigint,
@EmpTransactId int
)

as 
begin
if @EmpTransactId=1
begin
insert into tblEmpTransaction (EmpName,PaymentStatus,Amount) values(@EmpName,@PaymentStatus,@Amount)
end
end


create table State
(
StateID bigint identity(1,1),
StateName nvarchar(200)
)

select * from State;

alter procedure Pro_InsertStateNames
(
@StateID bigint=0,
@StateName nvarchar(200),
@StateTransactionId int
)

as
begin
if @StateTransactionId=1
begin
insert into State (StateName) values(@StateName)
end
end

alter procedure Pro_FetchStateName
as
begin
select StateName from State
end

create procedure Pro_FetchIDState(@StateName nvarchar(200))
as
begin
select StateID from State where StateName=@StateName
end 

create table District
(
DistrictID bigint identity(1,1),
StateID bigint,
DistrictName nvarchar(200)
)

select * from District
drop table District

alter procedure Pro_InsertDistrictNames
(
@DistrictID bigint=0,
@StateID bigint,
@DistrictName nvarchar(200),
@DistrictTransactionId int
)

as
begin
if @DistrictTransactionId=1
begin
insert into District (StateID,DistrictName) values(@StateID,@DistrictName)
end
end

create procedure Pro_FetchDistrictName
as
begin
select DistrictName from District
end

create procedure Pro_FetchIDDistrict(@DistrictName nvarchar(200))
as
begin
select DistrictID from District where DistrictName=@DistrictName
end 

create table Taluka
(
TalukaID bigint identity(1,1),
DistrictID bigint,
TalukaName nvarchar(200)
)

select * from Taluka
drop table Taluka

alter procedure Pro_InsertTalukaNames
(
@TalukaID bigint=0,
@DistrictID bigint,
@TalukaName nvarchar(200),
@TalukaTransactionId int
)

as
begin
if @TalukaTransactionId=1
begin
insert into Taluka (DistrictID,TalukaName) values(@DistrictID,@TalukaName)
end
end

create procedure Pro_FetchTalukaName
as
begin
select TalukaName from Taluka
end

create procedure Pro_FetchIDTaluka(@TalukaName nvarchar(200))
as
begin
select TalukaID from Taluka where TalukaName=@TalukaName
end 

create table SaveFields
(
Savefield bigint identity(1,1),
SaveState nvarchar(200),
SaveDistrict nvarchar(200),
SaveTaluka nvarchar(200)
)

select * from SaveFields

create procedure Pro_insertSave
(
@Savefield bigint=0,
@SaveState nvarchar(200),
@SaveDistrict nvarchar(200),
@SaveTaluka nvarchar(200),
@Savetransactionid int
)
as
begin
if @Savetransactionid=1
begin
insert into SaveFields(SaveState,SaveDistrict,SaveTaluka) values(@SaveState,@SaveDistrict,@SaveTaluka)
end
end