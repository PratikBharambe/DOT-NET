using _25DBAttributeLib;

namespace _26EmployeeLib
{
    [Table(TableName ="Employee")]
    public class Employee
    {
        private int _Id;
        private string _Name;
        private string _Address;

        [Column(ColumnName ="ID", ColumnType ="int")]
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        [Column(ColumnName = "Name", ColumnType = "varchar(30)")]
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        [Column(ColumnName = "Address", ColumnType = "varchar(60)")]
        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }
    }
}
