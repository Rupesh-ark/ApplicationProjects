USE [StockExchangeManagement]
GO
/****** Object:  StoredProcedure [dbo].[spUpdateCustomers]    Script Date: 12/27/2020 4:39:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[spUpdateCustomers](@customerID varchar(10),
								@customerName varchar(20),
								@cusPass varchar(10),
								@customerAddress varchar(20),
								@customerNum varchar(10))
						As
							BEGIN
								update dbo.Customers
								set
								customerName = @customerName,
								cusPass = @cusPass,
								customerAddress = @customerAddress,
								customerNum = @customerNum
								where
								customerID = @customerID;
							END
--------------------------------------------------------------------------------------------------------------------
USE [StockExchangeManagement]
GO
/****** Object:  StoredProcedure [dbo].[spUpdateCompany]    Script Date: 12/27/2020 4:39:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[spUpdateCompany](@companyID varchar(10),
															@companyName varchar(10),
															@companyType varchar(10),
															@marketCapital int,
															@yearEstablished smallint,
															@seName varchar(6))
				As
					BEGIN
						update dbo.Companies
						set
						companyName = @companyName,
						companyType = @companyType,
						marketCapital = @marketCapital,
						yearEstablished = @yearEstablished,
						seName = @seName
						where
						companyID = @companyID;
					END

--------------------------------------------------------------------------------------------------------------------
USE [StockExchangeManagement]
GO
/****** Object:  StoredProcedure [dbo].[spUpdateBrokers]    Script Date: 12/27/2020 4:39:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[spUpdateBrokers](@brokerID varchar(10),
																						@brokerName varchar(20),
																						@brokerPass varchar(10),
																						@commision money,
																						@seName varchar(6))
																				As
																					BEGIN
																						update dbo.Brokers
																						set
																						brokerName = @brokerName,
																						brokerPass = @brokerPass,
																						commision = @commision,
																						seName = @seName
																						where
																						brokerLoginID = @brokerID;
																					END

--------------------------------------------------------------------------------------------------------------------
USE [StockExchangeManagement]
GO
/****** Object:  StoredProcedure [dbo].[spStockExchange_GetName]    Script Date: 12/27/2020 4:39:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[spStockExchange_GetName]
as
begin
	select stk.seName as 'seName' from StockExchange stk;
end
--------------------------------------------------------------------------------------------------------------------
USE [StockExchangeManagement]
GO
/****** Object:  StoredProcedure [dbo].[spInsertCustomers]    Script Date: 12/27/2020 4:39:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[spInsertCustomers](@customerID varchar(10),
								@customerName varchar(20),
								@cusPass varchar(10),
								@customerAddress varchar(20),
								@customerNum varchar(10))
						As
							BEGIN
								INSERT INTO dbo.Customers(customerID,customerName,cusPass,customerAddress,customerNum)
								Values(@customerID,@customerName,@cusPass,@customerAddress,@customerNum)
							END
--------------------------------------------------------------------------------------------------------------------
USE [StockExchangeManagement]
GO
/****** Object:  StoredProcedure [dbo].[spInsertCompany]    Script Date: 12/27/2020 4:39:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[spInsertCompany](@companyID varchar(10),
															@companyName varchar(10),
															@companyType varchar(10),
															@marketCapital int,
															@yearEstablished smallint,
															@seName varchar(6))
													As
														BEGIN
															INSERT INTO dbo.Companies(companyID,companyName,companyType,marketCapital,yearEstablished,seName)
															Values(@companyID,@companyName,@companyType,@marketCapital,@yearEstablished,@seName)
														END
--------------------------------------------------------------------------------------------------------------------
USE [StockExchangeManagement]
GO
/****** Object:  StoredProcedure [dbo].[spInsertBrokers]    Script Date: 12/27/2020 4:39:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[spInsertBrokers](@brokerID varchar(10),
								@brokerName varchar(20),
								@brokerPass varchar(10),
								@commision money,
								@seName varchar(6))
						As
							BEGIN
								INSERT INTO dbo.Brokers
								Values(@brokerID,@brokerName,@brokerPass,@commision,@seName)
							END
-------------------------------------------------------------------------------------------------------------------------------
USE [StockExchangeManagement]
GO
/****** Object:  StoredProcedure [dbo].[spDeleteCustomer]    Script Date: 12/27/2020 4:39:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[spDeleteCustomer](@customerID varchar(10))
	AS
		BEGIN
			delete from dbo.Customers
			where customerID = @customerID;
		END
---------------------------------------------------------------------------------------------------------------------------------
USE [StockExchangeManagement]
GO
/****** Object:  StoredProcedure [dbo].[spDeleteCompany]    Script Date: 12/27/2020 4:39:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[spDeleteCompany](@companyID varchar(10))
	AS
		BEGIN
			delete from dbo.Companies
			where companyID = @companyID;
		END
----------------------------------------------------------------------------------------------------------------------------------
USE [StockExchangeManagement]
GO
/****** Object:  StoredProcedure [dbo].[spDeleteBroker]    Script Date: 12/27/2020 4:39:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[spDeleteBroker](@brokerID varchar(10))
	AS
		BEGIN
			delete from dbo.Brokers
			where brokerLoginID = @brokerID;
		END
----------------------------------------------------------------------------------------------------------------------------------
USE [StockExchangeManagement]
GO
/****** Object:  StoredProcedure [dbo].[spCustomer_GetAll]    Script Date: 12/27/2020 4:39:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[spCustomer_GetAll]
as
begin
	select cust.customerID as 'customerID',cust.cusPass as 'cusPass',cust.customerName as 'customerName',cust.customerAddress as 'customerAddress',cust.customerNum as 'customerNum' from Customers cust;
end

---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
USE [StockExchangeManagement]
GO
/****** Object:  StoredProcedure [dbo].[spCompany_GetAll]    Script Date: 12/27/2020 4:39:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[spCompany_GetAll]
as
begin
	select comp.companyID as 'companyID',comp.companyName as 'companyName',comp.companyType as 'companyType',comp.marketCapital as 'marketCapital',comp.yearEstablished as 'yearEstablished',comp.seName as 'seName' from Companies comp;
end
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
USE [StockExchangeManagement]
GO
/****** Object:  StoredProcedure [dbo].[spBroker_GetAll]    Script Date: 12/27/2020 4:39:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[spBroker_GetAll]
as
begin
	select bro.brokerLoginID as 'brokerID',bro.brokerPass as 'password',bro.brokerName as 'brokerName',bro.commision as 'commision',bro.seName as 'seName' from Brokers bro;
end
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
