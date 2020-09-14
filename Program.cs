using System;

namespace HomeWork12
{
    class Program
    {
        static void Main(string[] args)
        {
            private static readonly SqlConnection connection = new SqlConnection() { ConnectionString = "Server = DESKTOP - EHO5LMS\\SQLEXPRESS; Database = KazShop; Trusted_Connection=True;" };
        ConnectionString = ddd;

            DbProviderFactories.RegisterFactory("provider", SqlClientFactory.Instance);
            var providerFactory = DbProviderFactories.GetFactory("provider");


        var dataSet = new DataSet("Online shop");
        var dataAdapter = providerFactory.CreateDataAdapter();

        var selectCommand = providerFactory.CreateCommand();
        var connection = providerFactory.CreateConnection();

        connection.ConnectionString = "Server = (localdb)\\MSSQLLocaldb; Database = autolevelDb;Trusted_Connection = True;";
            selectCommand.CommandText = "select + from Users";
            selectCommand.Connection = connection;

            dataAdapter.SelectCommand = selectCommand;

            var CommandBuilder = providerFactory.CreateCommandBuilder();
        CommandBuilder.DataAdapter = dataAdapter;
            dataAdapter.InsertCommand = CommandBuilder.GetDeleteCommand();
            dataAdapter.UpdateCommand = CommandBuilder.GetDeleteCommand();
            dataAdapter.DeleteCommand = CommandBuilder.GetDeleteCommand();

            dataAdapter.Fill(dataSet);

            DataTable usersTable = new DataTable("Users");
        DataColumn idColumn = new DataColumn();
        idColumn.ColumnName = "id";
            idColumn.DataType = typeof(int);
            idColumn.AllowDBNull = false;
            idColumn.AutoIncrement = true;
            idColumn.Unique = true;

            usersTable.Columns.Add(idColumn);
            usersTable.PrimaryKey = new DataColumn[] { idColumn
    };

    DataColumn emailColumn = new DataColumn();
    emailColumn.ColumnName = "id";
            emailColumn.DataType = typeof(string);
            emailColumn.AllowDBNull = false;
            emailColumn.Unique = true;
            emailColumn.MaxLength = 20;

            usersTable.Columns.Add(emailColumn);

            DataColumn passwordColumn = new DataColumn();
    passwordColumn.ColumnName = "id";
            passwordColumn.DataType = typeof(string);
            passwordColumn.AllowDBNull = false;
            passwordColumn.Unique = true;
            passwordColumn.MaxLength = 20;

            usersTable.Columns.Add(passwordColumn);

            DataRow row = usersTable.NewRow();
    row.ItemArray = new object[] { 1, "Admin","12345" };
usersTable.Rows.Add(row);

            DataTable categoriesTable = new DataTable("Categories");

dataSet.Tables.Add(categoriesTable);
            DataColumn smartPhoneColumn = new DataColumn();
smartPhoneColumn.ColumnName = "smart";
            smartPhoneColumn.DataType = typeof(string);
            smartPhoneColumn.AllowDBNull = false;
            smartPhoneColumn.Unique = true;
            smartPhoneColumn.MaxLength = 10;

            usersTable.Columns.Add(smartPhoneColumn);

            dataSet.Tables.Add(categoriesTable);
            DataColumn pushbuttonPhonesColumn = new DataColumn();
pushbuttonPhonesColumn.ColumnName = "Button";
            pushbuttonPhonesColumn.DataType = typeof(string);
            pushbuttonPhonesColumn.AllowDBNull = false;
            pushbuttonPhonesColumn.Unique = true;
            pushbuttonPhonesColumn.MaxLength = 10;

            usersTable.Columns.Add(pushbuttonPhonesColumn);

            dataSet.Tables.Add(categoriesTable);
            DataColumn radioPhonesColumn = new DataColumn();
radioPhonesColumn.ColumnName = "radio";
            radioPhonesColumn.DataType = typeof(string);
            radioPhonesColumn.AllowDBNull = false;
            radioPhonesColumn.Unique = true;
            radioPhonesColumn.MaxLength = 10;

            usersTable.Columns.Add(radioPhonesColumn);


            DataTable sortingTable = new DataTable("Sorting");

dataSet.Tables.Add(categoriesTable);
            DataColumn NameColumn = new DataColumn();
NameColumn.ColumnName = "Name";
            NameColumn.DataType = typeof(string);
            NameColumn.AllowDBNull = false;
            NameColumn.Unique = true;
            NameColumn.MaxLength = 20;

            usersTable.Columns.Add(NameColumn);

            dataSet.Tables.Add(categoriesTable);
            DataColumn PriseColumn = new DataColumn();
PriseColumn.ColumnName = "Prise";
            PriseColumn.DataType = typeof(string);
            PriseColumn.AllowDBNull = false;
            PriseColumn.Unique = true;
            PriseColumn.MaxLength = 20;

            usersTable.Columns.Add(PriseColumn);

            DataRelation relation = new DataRelation(
                "users_profile_relation",
                "Users",
                "Profiles",
                new string[] { "Id" },
                new string[] { "UserId" },
                false);
dataSet.Relations.Add(relation);
    
           
        }
    }
}
