using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Repositories
{
    public class ManagerRepository:ConnectionManager
    {
        public static GridDepartmentRepository GridCompanyRepository = new GridDepartmentRepository();
        public static EmployeeRespository EmployeeRespository = new EmployeeRespository();
        public static DepartmentRepository DepartmentRepository = new DepartmentRepository();
        public bool GenerateDB()
        {
            bool ret = false;
            Execute((command) => 
            {
                command.CommandText = @"CREATE DATABASE [CompanyStructure1]";
                if(command.ExecuteNonQuery() != 0)
                {
                    ret = true;
                }
            });
            return ret;
        }

        public string GetDataBaseName()
        {
            string ret = "";
            Execute((command) =>
            {
                command.CommandText = @"SELECT [name] FROM [sys].[databases] WHERE[name] = N'CompanyStructure1'";
                ret = (string)command.ExecuteScalar();
            });
            return ret;
        }

        public bool GenerateTables()
        {
            bool ret = false;
            Execute((command) => 
            {
                command.CommandText = @"CREATE TABLE [dbo].[Department](
	                                [Id] [int] IDENTITY(1,1) NOT NULL,
	                                [Name] [nvarchar](50) NULL,
	                                [DepartmentTypeId] [int] NULL,
	                                [ParentDepartmentId] [int] NULL,
	                                [CheifEmployeeId] [int] NULL,
                                    CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED 
                                (
	                                [Id] ASC
                                )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
                                ) ON [PRIMARY]

                                CREATE TABLE [dbo].[DepartmentType](
	                                [Id] [int] IDENTITY(1,1) NOT NULL,
	                                [Name] [nvarchar](50) NULL,
                                    CONSTRAINT [PK_DepartmentType] PRIMARY KEY CLUSTERED 
                                (
	                                [Id] ASC
                                )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
                                ) ON [PRIMARY]

                                CREATE TABLE [dbo].[Employee](
	                                [Id] [int] IDENTITY(1,1) NOT NULL,
	                                [Name] [nvarchar](50) NULL,
	                                [Surname] [nvarchar](50) NULL,
	                                [Degree] [nvarchar](50) NULL,
	                                [Phone] [int] NULL,
	                                [Mail] [nvarchar](50) NULL,
	                                [DepartmentId] [int] NULL,
                                    CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
                                (
	                                [Id] ASC
                                )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
                                ) ON [PRIMARY]

                                ALTER TABLE [dbo].[Department]  WITH CHECK ADD  CONSTRAINT [FK_Department_DepartmentOf] FOREIGN KEY([ParentDepartmentId])
                                REFERENCES [dbo].[Department] ([Id])

                                ALTER TABLE [dbo].[Department] CHECK CONSTRAINT [FK_Department_DepartmentOf]

                                ALTER TABLE [dbo].[Department]  WITH CHECK ADD  CONSTRAINT [FK_Department_DepartmentType] FOREIGN KEY([DepartmentTypeId])
                                REFERENCES [dbo].[DepartmentType] ([Id])

                                ALTER TABLE [dbo].[Department] CHECK CONSTRAINT [FK_Department_DepartmentType]

                                ALTER TABLE [dbo].[Department]  WITH CHECK ADD  CONSTRAINT [FK_Department_Employee] FOREIGN KEY([CheifEmployeeId])
                                REFERENCES [dbo].[Employee] ([Id])

                                ALTER TABLE [dbo].[Department] CHECK CONSTRAINT [FK_Department_Employee]

                                ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Department] FOREIGN KEY([DepartmentId])
                                REFERENCES [dbo].[Department] ([Id])

                                ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Department]

                                Insert into DepartmentType(Name)
                                VALUES('Company')
                                Insert into DepartmentType(Name)
                                VALUES('Division')
                                Insert into DepartmentType(Name)
                                VALUES('Project')
                                Insert into DepartmentType(Name)
                                VALUES('Department')";
                if(command.ExecuteNonQuery() != 0)
                {
                    ret = true;
                }
            });
            return ret;
        }
    }
}
