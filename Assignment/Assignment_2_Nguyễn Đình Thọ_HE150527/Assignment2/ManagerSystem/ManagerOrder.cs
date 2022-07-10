﻿using System;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Linq;


namespace ManagerSystem
{
    public record Order { 
        public int OrderID { get; set; }
        public int MemberID { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public decimal Freight { get; set; }


    }
    public class ManagerOrder
    {
        SqlConnection connection;
        SqlCommand command;
        string ConnectionString = "Server=DESKTOP-JC1AF1T;uid=sa;pwd=17122001;database=SalesManagement";
        //private static List<Order> orders = new List<Order> { };

        public List<Order> GetOrders() {
            List<Order> orders = new List<Order>();
            connection = new SqlConnection(ConnectionString);
            string SQL = "SELECT OrderID,MemberID,OrderDate,RequiredDate,ShippedDate,Freight FROM [Order]";
            command = new SqlCommand(SQL, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.HasRows == true)
                {
                    while (reader.Read())
                    {
                        orders.Add(new Order
                        {
                            OrderID = reader.GetInt32("OrderID"),
                            MemberID = reader.GetInt32("MemberID"),
                            OrderDate = reader.GetDateTime("OrderDate"),
                            RequiredDate = reader.GetDateTime("RequiredDate"),
                            ShippedDate = reader.GetDateTime("ShippedDate"),
                            Freight = reader.GetDecimal("Freight")
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return orders;
        }

        //public List<Order> GetOrdersByOrderID(int id) {
        //    return orders.Where(Order => id == Order.OrderID).ToList();
        //}

        //public List<Order> GetOrdersByMemberID(int mid)
        //{
        //    return orders.Where(Order => mid == Order.MemberID).ToList();
        //}


        public void InsertOrder(Order order)
        {
            connection = new SqlConnection(ConnectionString);
            command = new SqlCommand("Insert [Order] values(@MemberID, @OrderDate, @RequiredDate, @ShippedDate, @Freight)", connection);
            command.Parameters.AddWithValue("@MemberID", order.MemberID);
            command.Parameters.AddWithValue("@OrderDate", order.OrderDate);
            command.Parameters.AddWithValue("@RequiredDate", order.RequiredDate);
            command.Parameters.AddWithValue("@ShippedDate", order.ShippedDate);
            command.Parameters.AddWithValue("@Freight",order.Freight);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void UpdateOrder(Order order)
        {
            connection = new SqlConnection(ConnectionString);
            command = new SqlCommand("Update [Order] set MemberID =  @MemberID ,OrderDate =  @OrderDate ,RequiredDate =  @RequiredDate ,ShippedDate =  @ShippedDate ,Freight =  @Freight where OrderID = @OrderID", connection);
            command.Parameters.AddWithValue("@MemberID", order.MemberID);
            command.Parameters.AddWithValue("@OrderDate", order.OrderDate);
            command.Parameters.AddWithValue("@RequiredDate", order.RequiredDate);
            command.Parameters.AddWithValue("@ShippedDate", order.ShippedDate);
            command.Parameters.AddWithValue("@Freight", order.Freight);
            command.Parameters.AddWithValue("@OrderID", order.OrderID);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void DeleteOrder(Order order)
        {
            connection = new SqlConnection(ConnectionString);
            command = new SqlCommand("Delete [Order] where OrderID = @OrderID", connection);
            command.Parameters.AddWithValue("@OrderID", order.OrderID);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

    }
}
