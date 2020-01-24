using System;
using System.Collections;
using System.Collections.Generic;

namespace LINQ_Tutorial.MockData
{
    public class DataGenerator
    {
        public static IEnumerable<User> GetUsers()
        {
            return new List<User>
            {
                new User {
                    Id = new Guid("1f7778d1-da5f-4c60-8b14-0cad7e20a56e"),
                    InstitutionID = new Guid("43634aa6-8db2-4b4a-956d-12cc6aaa2472"),
                    FullName = "Turbertus Talenti",
                    LoginName = "turbertus",
                    UserRole = UserRole.DOCTOR,
                    DateOfBirth = new DateTime(1980, 12, 6),
                    Hobbies = new List<string>() { "3D printing", "reading"}
                },
                new User {
                    Id = new Guid("8a345a04-ff6b-4d0f-bf8d-a43ccf5f7119"),
                    InstitutionID = new Guid("1243ff5d-08f4-4fda-b8b8-7de312b9b9e1"),
                    FullName = "Spertias d'Aufai",
                    LoginName = "spertias",
                    UserRole = UserRole.STUDY_ADMIN,
                    DateOfBirth = new DateTime(1989, 04, 08),
                    Hobbies = new List<string>() { "gaming", "reading"},
                    AddressId = new Guid("47797641-c533-4240-99cc-4427b30c7a58")
                },
                new User {
                    Id = new Guid("ea2ca41c-dfc8-4afc-a0c6-bc5201095da1"),
                    InstitutionID = new Guid("43634aa6-8db2-4b4a-956d-12cc6aaa2472"),
                    FullName = "Waldef Brugger",
                    LoginName = "waldef",
                    UserRole = UserRole.DOCTOR,
                    DateOfBirth = new DateTime(1974, 07, 13),
                    Hobbies = new List<string>() { "skiing", "knitting", "3D printing"}
                },
                new User {
                    Id = new Guid("109cf32a-30a4-4105-bbff-a9a6ab70e1ee"),
                    InstitutionID = new Guid("51fd5201-a0d1-49cd-b995-2fbcdd2a0d5f"),
                    FullName = "Georgius Ferrari",
                    LoginName = "georgius",
                    UserRole = UserRole.MONITOR,
                    DateOfBirth = new DateTime(1992, 01, 27),
                    Hobbies = new List<string>() {"reading", "gardening"}
                },
                new User {
                    Id = new Guid("3243b8e7-a6b4-4c33-b375-242f4e94a02f"),
                    InstitutionID = new Guid("1243ff5d-08f4-4fda-b8b8-7de312b9b9e1"),
                    FullName = "Willmot Vries",
                    LoginName = "willmot",
                    UserRole = UserRole.MONITOR,
                    DateOfBirth = new DateTime(1967, 03, 14),
                    Hobbies = new List<string>() { "cooking", "gunsmithing" }
                },
                new User {
                    Id = new Guid("567b145b-876e-4e82-9071-c8a7f7c31667"),
                    InstitutionID = new Guid("43634aa6-8db2-4b4a-956d-12cc6aaa2472"),
                    FullName = "Radoald Friedek",
                    LoginName = "radoald",
                    UserRole = UserRole.DOCTOR,
                    DateOfBirth = new DateTime(1988, 02, 17),
                    Hobbies = new List<string>() { "gaming", "dancing", "drawing"}
                },
                new User {
                    Id = new Guid("948068b8-7b67-4298-bafa-ac7227663ed5"),
                    InstitutionID = new Guid("43634aa6-8db2-4b4a-956d-12cc6aaa2472"),
                    FullName = "Syncerastus Viator",
                    LoginName = "syncerastus",
                    UserRole = UserRole.STUDY_ADMIN,
                    DateOfBirth = new DateTime(1989, 06, 12),
                    Hobbies = new List<string>() { "gunsmithing", "drawing"}
                },
                new User {
                    Id = new Guid("4b732aa4-ffec-410a-b6c9-66f46f13205f"),
                    InstitutionID = new Guid("51fd5201-a0d1-49cd-b995-2fbcdd2a0d5f"),
                    FullName = "Dionysia Augustalis",
                    LoginName = "dionysia",
                    UserRole = UserRole.DATA_PROVIDER,
                    DateOfBirth = new DateTime(1988, 05, 02),
                    Hobbies = new List<string>() { "gaming", "3D printing" }
                },
                new User {
                    Id = new Guid("f2c1017f-b878-4d0a-874e-c1b588f5100b"),
                    InstitutionID = new Guid("1243ff5d-08f4-4fda-b8b8-7de312b9b9e1"),
                    FullName = "Favonia Sidonius",
                    LoginName = "favonia",
                    UserRole = UserRole.DATA_MANAGER,
                    DateOfBirth = new DateTime(1992, 09, 20),
                    Hobbies = new List<string>() { "gardening", "drawing"},
                    AddressId = new Guid("f6855c67-dacc-4921-abab-286f3d99d0a4")
                }
            };
        }

        public static IEnumerable<Address> GetAddresses()
        {
            return new List<Address>
            {
                new Address
                {
                    Id = new Guid("f6855c67-dacc-4921-abab-286f3d99d0a4"),
                    Country = "HU",
                    County = "Budapest",
                    Settlement = "Budapest",
                    StreetAddress = "Kőér u. 2/A.",
                    Zip = "1103"
                },
                new Address
                {
                    Id = new Guid("47797641-c533-4240-99cc-4427b30c7a58"),
                    Country = "HU",
                    County = "Csongrád",
                    Settlement = "Szeged",
                    StreetAddress = "Back Bernát u. 6.",
                    Zip = "6728"
                }
            };
        }

        public static IEnumerable<Institution> GetInstitutions()
        {
            return new List<Institution> {
                new Institution() {
                    Id = new Guid("43634aa6-8db2-4b4a-956d-12cc6aaa2472"),
                    Name = "Lakeside Clinic"
                },
                new Institution() {
                    Id = new Guid("1243ff5d-08f4-4fda-b8b8-7de312b9b9e1"),
                    Name = "Silverwood Community Hospital"
                },
                new Institution() {
                    Id = new Guid("51fd5201-a0d1-49cd-b995-2fbcdd2a0d5f"),
                    Name = "Southshore Hospital Center"
                }
            };
        }

        public static IEnumerable<string> GetNames()
        {
            return new List<string> {
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

        public static IEnumerable<int> GetIntegerList1()
        {
            return new List<int> { 4, 6, 1, 34, -7, -23, 6, 8, 8, -57 };
        }

        public static IEnumerable<int> GetIntegerList2()
        {
            return new List<int> { 4, 10, 45, 11, 7, -49, 23, 8, 98 };
        }

        public static IEnumerable<int> GetIntegerList3()
        {
            return new List<int> { 4, 10, 45, 11, 7, -49, 23, 8, 98 };
        }

        public static IEnumerable<int> GetIntegerList4()
        {
            return new List<int> { 4, 6, 8, 36, 64, 88, 100, 108 };
        }

        public static IEnumerable<int> GetIntegerList5()
        {
            return new List<int> { 9, 25, 36, 49, 64, 81, 100, 121 };
        }

        public static IList GetMixedList()
        {
            return new ArrayList
            {
                45,
                "eloquence",
                78,
                3.8,
                new User {
                    FullName = "Virus Kunz"
                }
            };
        }

        public static IEnumerable<string> GetInvoices()
        {
            return new List<string>
            {
                "AGDF326534",
                "5234GSGBNX",
                "AGDF326534",
                "KDFHDF43GF",
                "CBSDGS35AG",
                "LFGHBD3534",
                "KDFHDF43GF",
                "CAQQ42HFCN"
            };
        }
    }
}
