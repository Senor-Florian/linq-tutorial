using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Tutorial.MockData
{
    public class DataGenerator
    {
        public static List<User> GetUsers()
        {
            return new List<User>()
            {
                new User() {
                    ID = new Guid("1f7778d1-da5f-4c60-8b14-0cad7e20a56e"),
                    InstitutionID = new Guid("43634aa6-8db2-4b4a-956d-12cc6aaa2472"),
                    FullName = "Turbertus Talenti",
                    LoginName = "turbertus",
                    UserRole = UserRole.DOCTOR,
                    DateOfBirth = Convert.ToDateTime("1980-12-6"),
                    Hobbies = new List<string>() { "3D printing", "reading"}
                },
                new User() {
                    ID = new Guid("8a345a04-ff6b-4d0f-bf8d-a43ccf5f7119"),
                    InstitutionID = new Guid("1243ff5d-08f4-4fda-b8b8-7de312b9b9e1"),
                    FullName = "Spertias d'Aufai",
                    LoginName = "spertias",
                    UserRole = UserRole.STUDY_ADMIN,
                    DateOfBirth = Convert.ToDateTime("1989-04-08"),
                    Hobbies = new List<string>() { "gaming", "reading"}
                },
                new User() {
                    ID = new Guid("ea2ca41c-dfc8-4afc-a0c6-bc5201095da1"),
                    InstitutionID = new Guid("43634aa6-8db2-4b4a-956d-12cc6aaa2472"),
                    FullName = "Waldef Brugger",
                    LoginName = "waldef",
                    UserRole = UserRole.DOCTOR,
                    DateOfBirth = Convert.ToDateTime("1974-07-13"),
                    Hobbies = new List<string>() { "skiing", "knitting", "3D printing"}
                },
                new User() {
                    ID = new Guid("109cf32a-30a4-4105-bbff-a9a6ab70e1ee"),
                    InstitutionID = new Guid("51fd5201-a0d1-49cd-b995-2fbcdd2a0d5f"),
                    FullName = "Georgius Ferrari",
                    LoginName = "georgius",
                    UserRole = UserRole.MONITOR,
                    DateOfBirth = Convert.ToDateTime("1992-01-27"),
                    Hobbies = new List<string>() {"reading", "gardening"}
                },
                new User() {
                    ID = new Guid("3243b8e7-a6b4-4c33-b375-242f4e94a02f"),
                    InstitutionID = new Guid("1243ff5d-08f4-4fda-b8b8-7de312b9b9e1"),
                    FullName = "Willmot Vries",
                    LoginName = "willmot",
                    UserRole = UserRole.MONITOR,
                    DateOfBirth = Convert.ToDateTime("1967-03-14"),
                    Hobbies = new List<string>() { "cooking", "gunsmithing" }
                },
                new User() {
                    ID = new Guid("567b145b-876e-4e82-9071-c8a7f7c31667"),
                    InstitutionID = new Guid("43634aa6-8db2-4b4a-956d-12cc6aaa2472"),
                    FullName = "Radoald Friedek",
                    LoginName = "radoald",
                    UserRole = UserRole.DOCTOR,
                    DateOfBirth = Convert.ToDateTime("1988-02-17"),
                    Hobbies = new List<string>() { "gaming", "dancing", "drawing"}
                }
            };
        }

        public static List<Institution> GetInstitutions()
        {
            return new List<Institution>() {
                new Institution() {
                    ID = new Guid("43634aa6-8db2-4b4a-956d-12cc6aaa2472"),
                    Name = "Lakeside Clinic"
                },
                new Institution() {
                    ID = new Guid("1243ff5d-08f4-4fda-b8b8-7de312b9b9e1"),
                    Name = "Silverwood Community Hospital"
                },
                new Institution() {
                    ID = new Guid("51fd5201-a0d1-49cd-b995-2fbcdd2a0d5f"),
                    Name = "Southshore Hospital Center"
                }
            };
        }

        public static List<string> GetNames()
        {
            return new List<string>() {
                "Geffrei Neubert",
                "Alizaunder Bonauiti",
                "Artor Lerch",
                "Cniva Labouré",
                "Euryhus Dekever",
                "Eduuin Sprecher",
                "Ciprianus Larosière",
                "Hemonnet Garavini",
                "Sansalas Bosman",
                "Virus Kunz"
            };
        }

        public static List<int> GetIntegerList1()
        {
            return new List<int>() { 4, 6, 1, 34, -7, -23, 6, 8, 8, -57 };
        }

        public static List<int> GetIntegerList2()
        {
            return new List<int>() { 4, 10, 45, 11, 7, -49, 23, 8, 98 };
        }

        public static List<int> GetIntegerList3()
        {
            return new List<int>() { 4, 10, 45, 11, 7, -49, 23, 8, 98 };
        }

        public static IList GetMixedList()
        {
            return new ArrayList() {
                45,
                "eloquence",
                78,
                3.8,
                new User() {
                    FullName = "Virus Kunz"
                }
            };
        }
    }
}
