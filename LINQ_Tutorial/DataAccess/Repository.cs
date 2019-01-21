using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using LINQ_Tutorial.MockData;

namespace LINQ_Tutorial.DataAccess
{
    public class Repository
    {
        private DbConnection _dbConnection;

        public Repository(DbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<List<UserPoco>> SortUsers()
        {
            var sql = @"SELECT TOP 10 ID, FULLNAME, LOGINNAME, USERROLE
                        FROM USERS
                        WHERE DELETED = 0
                        ORDER BY USERROLE, FULLNAME";
            return (await _dbConnection.QueryAsync<UserPoco>(sql)).ToList();
        }

        public async Task<List<UserPoco>> FilterUsers()
        {
            var sql = @"SELECT TOP 10 ID, FULLNAME, LOGINNAME, USERROLE 
                        FROM USERS 
                        WHERE DELETED = 0 AND USERROLE = @userRole";
            return (await _dbConnection.QueryAsync<UserPoco>(sql, new { userRole = (int)UserRole.DOCTOR })).ToList();
        }

        public async Task<List<UserPoco>> SelectUsers()
        {
            var sql = @"SELECT TOP 10 FULLNAME 
                        FROM USERS 
                        WHERE DELETED = 0";
            return (await _dbConnection.QueryAsync<UserPoco>(sql)).ToList();
        }

        public async Task<List<UserPoco>> JoinUsers()
        {
            var sql = @"SELECT TOP 10 FULLNAME, ADDRESSES.COUNTRY AS COUNTRYCODE 
                        FROM USERS
                        LEFT JOIN ADDRESSES ON ADDRESSES.ID = USERS.ID
                        WHERE USERS.DELETED = 0";
            return (await _dbConnection.QueryAsync<UserPoco>(sql)).ToList();
        }
    }
}
