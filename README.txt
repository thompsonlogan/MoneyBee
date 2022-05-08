*****SNAL Repository*****

README updated 5/17/2020

*****General Description*****
Money Bee is a simplified budgeting application that allows its user to enter and track his/her transactions.
Further details about its anticipated capabilities are provided in our Jira Backlog

*****Build Instructions*****
Compile with Visual Studio 2019, when presented with the login form you can login with (admin, admin), (user, user), or register and create your own account.

*****Required Files*****
(in project src folder)
AddCategoryCommand.cs
AddTransactionCommand.cs
AutomaticList.cs
CancelAutoForm.Designer.cs
CancelAutoForm.cs
CancelAutoForm.resx
Category.cs
CategoryList.cs
Command.cs
DatabaseManager.cs
Date.cs
EditTransactionCommand.cs
EditTransactionForm.Designer.cs
EditTransactionForm.cs
EditTransactionForm.resx
Handler.cs
History.cs
LoginForm.Designer.cs
LoginForm.cs
LoginForm.resx
LoginManager.cs
MoneyBee - Long.jpg
MoneyBee.csproj
MoneyBee.csproj.user
MoneyBee.jpg
MoneyBee.sln
MoneyBeeDataBase.mdf
MoneyBeeDataBaseDataSet.Designer.cs
MoneyBeeDataBaseDataSet.xsc
MoneyBeeDataBaseSet.xsd
MoneyBeeDataBaseDataSet.xss
MoneyBeeDataBase_log.ldf
MoneyBeeForm.Designer.cs
MoneyBeeForm.cs
MoneyBeeForm.resx
MoneyBeeProgram.cs
Notifications.cs
RegisterForm.Designer.cs
RegisterForm.cs
RegisterForm.resx
RegistrationManager.cs
Transaction.cs
TransactionForm.Designer.cs
TransactionForm.cs
TransactionForm.resx
TransactionHistory.cs
TransactionManager.cs
User.cs

RemoveCategoryCommand.cs - missing

*****Known Bugs/Design Deficiencies*****
- New Transaction: Upon creation. The maximum amount for an expense/revenue automatically 0's off to avoid out of Int32 bounds (reason for bug: amount entered not intended to be excessively great)
- New Transaction: Attempting to undo after the creation of the above transaction will throw an error (reason for bug: same as listed above)
- Log in: After creating an example of the above transaction, the compiler will throw and error if that same user attempts to re-log (reason for bug: same as listed above)
- New Category: Setting a priority rating is limited to the Int32 limits. Throws error if out of bounds (reason for bug: originally designed with 0-10 scroll rating in mind)
- Money Bee Form (Settings Tab): The tab is almost empty other than a log out button (reason for UI deficiency: orignally designed to have more operations as shown in previous iterations of Money Bee)
- Automatic Transaction: Attempting to edit a transaction that has been generated automatically throws an error (reason for bug: bug found too late in development to resolve by deployment period)
- Delete Categories/Transactions: currently unable to delete unwanted categories and transactions (reason for deficiency: not enough to implement by time of deployment)
- Transaction in Database: Transaction number errors when being saved to database (reason for bug: more knowledge about database work required)

*****Regenerate Test Coverage Results*****
The following test sets can be tested by running as normal
- CategoryListTests
- CategoryTests
- DatabaseTests
- LoginManagerTests
- NotificationsTests
- RegistrationManagerTests
- TransactionHistoryTests
- TransactionTests
- UserTests
The following test sets need their contents updated to be relevant to current date
- DateTests

