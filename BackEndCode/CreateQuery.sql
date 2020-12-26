create table StockExchange(seName varchar(6) primary key,
  seLocation varchar(20) not null);

create table SEAdmin(adminID varchar(10) primary key,
  adminPass varchar(10) not null,
  adminName varchar(10) not null,
  seName varchar(6) foreign key references StockExchange(seName) on delete cascade);

create table Brokers(brokerLoginID varchar(10) primary key,
  brokerName varchar(20) not null,
  brokerPass varchar(10) not null,
  commision money not null,
  seName varchar(6) foreign key references StockExchange(seName) on delete cascade);

create table StockOrder(orderID varchar(10) primary key,
  orderQuantity smallint not null,
  purchaseAmt money not null,
  borkerID varchar(10) foreign key references Brokers(brokerLoginID) on delete no action on update no action,
  seName varchar(6) foreign key references StockExchange(seName) on delete cascade);

create table Companies(companyID varchar(10) primary key,
  companyName varchar(10) not null,
  companyType varchar(10) not null,
  marketCapital int not null,
  yearEstablished smallint not null,
  seName varchar(6) foreign key references StockExchange(seName) on delete cascade
);
create table Shares(shareName varchar(10) primary key,
  companyID varchar(10) foreign key references Companies(companyID) on delete cascade,
  changeInPrice money not null,
  openingPrice money not null,
  volume smallint not null,
  holdingsCost money not null
  );

create table StockQuote(companyID varchar(10) foreign key references Companies(companyID) on delete cascade,
  offer int not null,
  bid int not null
);


create table Performance(companyID varchar(10) foreign key references Companies(companyID) on delete cascade,
  financialYear smallint not null,
  P_E_Ratio smallint not null,
  netIncome money not null
);

create table Customers(customerID varchar(10) primary key,
 customerName varchar(20),
 cusPass varchar(10) not null,
 customerAddress varchar(20) not null,
 customerNum varchar(10) not null
);


create table ShareHolders(shareholderID varchar(10) primary key references Customers(customerID) on delete cascade,
  shareName varchar(10) foreign key references Shares(shareName) on delete cascade,
  shareValue money not null,
  gain money not null,
  numberOfShares int not null
);

create table custBalanceSheet(customerID varchar(10) foreign key references Customers(customerID) on delete cascade ,
  balance money not null,
  moneySpent money not null,
  totalShareValue money not null);

create table MasterTransaction(transactionID varchar(10) primary key,
  amount money not null,
  DateOfTransaction Datetime not null,
  seName varchar(6) foreign key references StockExchange(seName) on delete cascade);
