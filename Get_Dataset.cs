using System;
using System.Data;
using System.Data.SqlClient;

class Database
{
    private SqlConnection connection;
//Constructor
    public Database(string connectionString)
    {
        connection = new SqlConnection(connectionString);
    }
//Ejecutar select y devolver el dataset con el numero de columnas afectadas 
public int ExecuteSelect(string query, out DataSet dataSet)
{
    dataSet = new DataSet();
    int rowCount = 0;
    try
    {
        connection.Open();
        SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
        adapter.Fill(dataSet);
        rowCount = dataSet.Tables[0].Rows.Count;
    }
    catch (SqlException ex)
    {
        Console.WriteLine(ex.Message);
    }
    finally
    {
        connection.Close();
    }
    return rowCount;
}
//Método para Insertar y devolver el número de filas afectadas.
    public int ExecuteInsert(string query)
    {
        int affectedRows = 0;
        try
        {
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            affectedRows = command.ExecuteNonQuery();
        }
        catch (SqlException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            connection.Close();
        }
        return affectedRows;
    }
//Método para Actualizar y devolver el número de filas afectadas.
    public int ExecuteUpdate(string query)
    {
        int affectedRows = 0;
        try
        {
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            affectedRows = command.ExecuteNonQuery();
        }
        catch (SqlException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            connection.Close();
        }
        return affectedRows;
    }
//Método para Eliminar y devolver el número de filas afectadas.
    public int ExecuteDelete(string query)
    {
        int affectedRows = 0;
        try
        {
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            affectedRows = command.ExecuteNonQuery();
        }
        catch (SqlException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            connection.Close();
        }
        return affectedRows;
    }
}

