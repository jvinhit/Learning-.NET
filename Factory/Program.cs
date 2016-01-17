using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//tao mot nha may don gian nhu sau
//co 3 loai users: admin, support, user
//user khac nhau, se co description khac nhau
//version 1
public interface FactoryUser
{

    IUsers createUser(string type);

}
//~ 
/*public abstract class ConnectionFactory
 * {
 *      public Connection createConnection(string type);
 * }
 * 
 * public class SecureFactory extends ConnectionFactory
 * {
 *      public SecureFactory(){}
 *      public Connection createConnection(string type)
 *      {
 *          if(type.Equals("Oracle")) {
 *              return new SecureOracleConnection();
 *              
 *          }
 *          else if (type.Equals("SQL")) {
 *              return new SecureSQlConnection();
 *          }
 *          else {
 *              return new SecureMySqlConnection():
 *          }
 *      }
 * }
 * 
 * public class SecureOracleConnection
 * {
 *      public SecureOracleConnection(){}
 *      public string Description()
 *      {
 *          return "Oracle secure!";
 *      }
 * 
 * Khai bao da xong gio ta su dung no 
 * Main(){
 *  SecureFactory s = new SercureFactory();
 *  Connection conn = s.createConnection("SQl");
 * }
 */

public class SecureFactory : FactoryUser
{
    public IUsers createUser(string type)
    {
        if (type.Equals("admin", StringComparison.OrdinalIgnoreCase))
        {
            return new SecureAdmin();
        }
        else if (type.Equals("support", StringComparison.OrdinalIgnoreCase))
            return new SecureSupport();
        else
            return new SecureUser();

    }
}

public interface IUsers
{
    string description();
}
public class SecureAdmin : IUsers
{
    public string description()
    {
        return "Secure Admin";
    }
}
public class SecureUser : IUsers
{
    public string description()
    {
        return "Secure User";
    }
}
public class SecureSupport : IUsers
{
    public string description()
    {
        return "Secure Support";
    }
}

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            SecureFactory factory = new SecureFactory();
            IUsers user = factory.createUser("admin");
            Console.WriteLine(user.description());
            user = factory.createUser("support");
            Console.WriteLine(user.description());
            user = factory.createUser("user");
            Console.WriteLine(user.description());
        }
    }
}
