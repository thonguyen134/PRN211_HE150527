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
    public record OrderDetail { 
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public double Discount { get; set; }
    }
    public class ManagerOrderDetail
    {
        SqlConnection connection;
        SqlCommand command;
        string ConnectionString = "Server=DESKTOP-JC1AF1T;uid=sa;pwd=17122001;database=SalesManagement";
        //private static List<OrderDetail> orderDetails = new List<OrderDetail> { };

        public List<OrderDetail> GetOrderDetails() {
            List<OrderDetail> orderDetails = new List<OrderDetail>();
            connection = new SqlConnection(ConnectionString);
            string SQL = "SELECT OrderID,ProductID,UnitPrice,Quantity,Discount FROM OrderDetail";
            command = new SqlCommand(SQL, connection);
            try {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.HasRows == true) {
                    while (reader.Read())
                    {
                        orderDetails.Add(new OrderDetail
                        {
                            OrderID = reader.GetInt32("OrderID"),
                            ProductID = reader.GetInt32("ProductID"),
                            UnitPrice = reader.GetDecimal("UnitPrice"),
                            Quantity = reader.GetInt32("Quantity"),
                            Discount = reader.GetDouble("Discount")
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
            return orderDetails;
        }

        //public List<OrderDetail> GetOrderDetailByOrderID(int id) { 
        //    return orderDetails.Where(OrderDetail => id == OrderDetail.OrderID).ToList();
        //}

        //public List<OrderDetail> GetOrderDetailByProductID(int pid)
        //{
        //    return orderDetails.Where(OrderDetail => pid == OrderDetail.ProductID).ToList();
        //}

        public void InsertOrderDetail(OrderDetail orderDetail) {
            connection = new SqlConnection(ConnectionString);
            command = new SqlCommand("Insert OrderDetail values(@OrderId,@ProductID,@UnitPrice, @Quantity, @Discount)", connection);
            command.Parameters.AddWithValue("@OrderId", orderDetail.OrderID);
            command.Parameters.AddWithValue("@ProductID", orderDetail.ProductID);
            command.Parameters.AddWithValue("@UnitPrice", orderDetail.UnitPrice);
            command.Parameters.AddWithValue("@Quantity", orderDetail.Quantity);
            command.Parameters.AddWithValue("@Discount", orderDetail.Discount);
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

        public void UpdateOrderDetail(OrderDetail orderDetail) {
            connection = new SqlConnection(ConnectionString);
            command = new SqlCommand("Update OrderDetail set UnitPrice = @UnitPrice,Quantity = @Quantity,Discount = @Discount where OrderID = @OrderID and ProductID = @ProductID", connection);
            command.Parameters.AddWithValue("@UnitPrice", orderDetail.UnitPrice);
            command.Parameters.AddWithValue("@Quantity", orderDetail.Quantity);
            command.Parameters.AddWithValue("@Discount", orderDetail.Discount);
            command.Parameters.AddWithValue("@OrderID", orderDetail.OrderID);
            command.Parameters.AddWithValue("@ProductID", orderDetail.ProductID);

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

        public void DeleteOrderDetail(OrderDetail orderDetail)
        {
            connection = new SqlConnection(ConnectionString);
            command = new SqlCommand("Delete OrderDetail where OrderID = @OrderID and ProductID = @ProductID", connection);
            command.Parameters.AddWithValue("@OrderID", orderDetail.OrderID);
            command.Parameters.AddWithValue("@ProductID", orderDetail.ProductID);
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

