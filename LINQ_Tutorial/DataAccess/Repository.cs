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

        // SORTING
        public async Task<List<UserPoco>> SortUsers()
        {
            var sql = @"SELECT TOP 10 ID, FULLNAME, LOGINNAME, USERROLE
                        FROM USERS
                        WHERE DELETED = 0
                        ORDER BY USERROLE, FULLNAME";
            return (await _dbConnection.QueryAsync<UserPoco>(sql)).ToList();
        }
        // SETS
        public async Task<List<int>> GetUserRoles()
        {
            var sql = @"SELECT DISTINCT USERROLE
                        FROM USERS
                        WHERE DELETED = 0";

            return (await _dbConnection.QueryAsync<int>(sql)).ToList();
        }
        // ELEMENTS
        public async Task<UserPoco> GetFirstDoctorUser()
        {
            var sql = @"SELECT TOP 1 FULLNAME, LOGINNAME, USERROLE
                        FROM USERS
                        WHERE DELETED = 0 AND USERROLE = @userRole";
            return (await _dbConnection.QueryAsync<UserPoco>(sql, new { userRole = (int)UserRole.DOCTOR })).SingleOrDefault();
        }

        public async Task<UserPoco> GetLastDoctorUser()
        {
            var sql = @"SELECT TOP 1 FULLNAME, LOGINNAME, USERROLE
                        FROM USERS
                        WHERE DELETED = 0 AND USERROLE = @userRole
                        ORDER BY USERROLE DESC";
            return (await _dbConnection.QueryAsync<UserPoco>(sql, new { userRole = (int)UserRole.DOCTOR })).SingleOrDefault();
        }
        //FILTERING
        public async Task<List<UserPoco>> GetDoctorUsers()
        {
            var sql = @"SELECT TOP 10 ID, FULLNAME, LOGINNAME, USERROLE 
                        FROM USERS 
                        WHERE DELETED = 0 AND USERROLE = @userRole";
            return (await _dbConnection.QueryAsync<UserPoco>(sql, new { userRole = (int)UserRole.DOCTOR })).ToList();
        }
        // PROJECTION
        public async Task<List<string>> SelectUserNames()
        {
            var sql = @"SELECT TOP 10 FULLNAME 
                        FROM USERS 
                        WHERE DELETED = 0";
            return (await _dbConnection.QueryAsync<string>(sql)).ToList();
        }
        // PARTITIONING
        public async Task<List<UserPoco>> GetFirstFiveUsers()
        {
            var sql = @"SELECT TOP 5 FULLNAME, LOGINNAME, USERROLE
                        FROM USERS
                        WHERE DELETED = 0";
            return (await _dbConnection.QueryAsync<UserPoco>(sql)).ToList();
        }
        // JOIN
        public async Task<List<UserPoco>> JoinUsers()
        {
            var sql = @"SELECT TOP 10 LOGINNAME, FULLNAME, USERROLE, ADDRESSES.COUNTRY AS COUNTRYCODE 
                        FROM USERS
                        LEFT JOIN ADDRESSES ON ADDRESSES.ID = USERS.ID
                        WHERE USERS.DELETED = 0 AND USERS.USERROLE = @userRole";
            return (await _dbConnection.QueryAsync<UserPoco>(sql, new { userRole = (int)UserRole.DOCTOR })).ToList();
        }
    }
}
