using System.Data;
using Dapper;

namespace SMS.DataAccessLayer.Interfaces
{
    public interface IDapperRepository
    {
        SqlMapper.GridReader Querymultiple(string spName, DynamicParameters param = null);
        int Exec(string spName, DynamicParameters param = null);
    }
}
