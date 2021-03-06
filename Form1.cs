﻿using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace APIUI
{
	public partial class Form1 : Form
	{
    private String _connectionString = null;
    //private String _connectionString = ConfigurationManager.ConnectionStrings["APIUI.Properties.Settings.hspp1devo3ConnectionString"].ConnectionString;

    public String connectionString { get { return _connectionString; } }

    public Form1(String InputString)
    {
      _connectionString = InputString;
      InitializeComponent();
    }

		

		private void Form1_Load(object sender, EventArgs e)
		{
			webServiceAccessTableAdapter.Fill(hspp1devo3DataSet.WebServiceAccess);
			label4.Text = string.Empty;
		}

		private void buttonLoad_Click(object sender, EventArgs e)
		{
			var selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
			if (selectedRowCount > 0)
			{
				for (var i = 0; i < selectedRowCount; i++)
				{
					resetUser();
					label4.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
					textBoxUserId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
					textBoxUserId.Enabled = false;
					textBoxNote.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
					textBoxNote.Enabled = false;
					textBoxIPAddress.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
					textBoxIPAddress.Enabled = false;
					loadUser();
				}
			}
		}

		private void loadUser()
		{
			var conn = new SqlConnection(connectionString);
      var comm = new SqlCommand("SELECT UserId, MethodName, VisibleProperties FROM WebServiceAccess WHERE UserId = '" + label4.Text + "'  AND IPAddress='" + textBoxIPAddress.Text + "'", conn);
			SqlDataReader reader;

			if (!string.IsNullOrEmpty(textBoxUserId.Text))
			{
				try
				{
					conn.Open();
					var _with1 = comm;
					_with1.Connection = conn;
					_with1.CommandType = CommandType.Text;
          _with1.CommandText = "SELECT UserId, MethodName FROM WebServiceAccess WHERE UserId = '" + label4.Text + "'  AND IPAddress='" + textBoxIPAddress.Text + "'";
					using (reader = _with1.ExecuteReader())
					{
						while (reader.Read())
						{
							if (reader.GetString(1).ToString().Equals("Item"))
							{
								checkBoxItem.Checked = true;
							}
							else
							{
								if (reader.GetString(1).Equals("PostOrder"))
								{
									checkBoxPostOrder.Checked = true;
								}
								else
								{
									if (reader.GetString(1).Equals("GetBomComponents"))
									{
										checkBoxGetBomComponents.Checked = true;
									}
									else
									{
										if (reader.GetString(1).Equals("GetBomList"))
										{
											checkBoxGetBomList.Checked = true;
										}
										else
										{
											if (reader.GetString(1).Equals("GetCommonlyReplacedItems"))
											{
												checkBoxGetCommonlyReplacedItems.Checked = true;
											}
											else
											{
												if (reader.GetString(1).Equals("GetDailySales"))
												{
													checkBoxGetDailySales.Checked = true;
												}
												else
												{
													if (reader.GetString(1).Equals("GetImageUrls"))
													{
														checkBoxGetImageUrls.Checked = true;
													}
													else
													{
														if (reader.GetString(1).Equals("GetInventoryListChanges"))
														{
															checkBoxGetInventoryListChanges.Checked = true;
														}
														else
														{
															if (reader.GetString(1).Equals("GetMasterInventoryList"))
															{
																checkBoxGetMasterInventoryList.Checked = true;
															}
															else
															{
																if (reader.GetString(1).Equals("GetMultipleItemDetail"))
																{
																	checkBoxGetMultipleItemDetail.Checked = true;
																}
																else
																{
																	if (reader.GetString(1).Equals("GetRealtimeItemStatus"))
																	{
																		checkBoxGetRealtimeItemStatus.Checked = true;
																	}
																	else
																	{
																		if (reader.GetString(1).Equals("GetRecommendedItems"))
																		{
																			checkBoxGetRecommendedItems.Checked = true;
																		}
																		else
																		{
																			if (reader.GetString(1).Equals("GetSalesOrder"))
																			{
																				checkBoxGetSalesOrder.Checked = true;
																			}
																			else
																			{
																				if (reader.GetString(1).Equals("GetSpecialPricedItems"))
																				{
																					checkBoxGetSpecialPricedItems.Checked = true;
																				}
																				else
																				{
																					if (reader.GetString(1).Equals("GetTrackingNumber"))
																					{
																						checkBoxGetTrackingNumber.Checked = true;
																					}
																					else
																					{
																						if (reader.GetString(1).Equals("GetTrackingNumberByDate"))
																						{
																							checkBoxGetTrackingNumberByDate.Checked = true;
																						}
                                            else
                                            {
                                              if (reader.GetString(1).Equals("GetCredits"))
                                              {
                                                checkBoxGetCredits.Checked = true;
                                              }
                                              else 
                                              {
                                                if (reader.GetString(1).Equals("GetInventoryOnHand"))
                                                {
                                                  checkBoxGetInventoryOnHand.Checked = true;
                                                }
                                                else
                                                {
                                                  if (reader.GetString(1).Equals("GetInvoice"))
                                                  {
                                                    checkBoxGetInvoice.Checked = true;
                                                  }
                                                  else
                                                  {
                                                    if (reader.GetString(1).Equals("GetInvoiceDateRange"))
                                                    {
                                                      checkBoxGetInvoiceDateRange.Checked = true;
                                                    }
                                                    else
                                                    {
                                                      if (reader.GetString(1).Equals("GetOrderStatus"))
                                                      {
                                                        checkBoxGetOrderStatus.Checked = true;
                                                      }
                                                      else
                                                      {
                                                        if (reader.GetString(1).Equals("GetInvoiceByPonum"))
                                                        {
                                                          checkBoxGetInvoiceByPonum.Checked = true;
                                                        }
                                                      }
                                                    }
                                                  }
                                                }
                                              }
                                            }
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
					reader.Close();
					conn.Close();
				}
				catch (SqlException exError)
				{
					MessageBox.Show("Error Connecting to Database: " + exError.Message);
				}
				finally
				{
					conn.Close();
					reader = null;
					comm.Dispose();
					comm = null;
					conn.Dispose();
					conn.Close();
				}
			}
		}

		private void resetUser()
		{
			checkBoxItem.Checked = false;
			checkBoxPostOrder.Checked = false;
			checkBoxGetBomComponents.Checked = false;
			checkBoxGetBomList.Checked = false;
			checkBoxGetCommonlyReplacedItems.Checked = false;
			checkBoxGetDailySales.Checked = false;
			checkBoxGetImageUrls.Checked = false;
			checkBoxGetInventoryListChanges.Checked = false;
			checkBoxGetMasterInventoryList.Checked = false;
			checkBoxGetMultipleItemDetail.Checked = false;
			checkBoxGetRealtimeItemStatus.Checked = false;
			checkBoxGetRecommendedItems.Checked = false;
			checkBoxGetSalesOrder.Checked = false;
			checkBoxGetSpecialPricedItems.Checked = false;
			checkBoxGetTrackingNumber.Checked = false;
			checkBoxGetTrackingNumberByDate.Checked = false;
      checkBoxGetCredits.Checked = false;
      checkBoxGetInventoryOnHand.Checked = false;
      checkBoxGetInvoice.Checked = false;
      checkBoxGetInvoiceByPonum.Checked = false;
      checkBoxGetInvoiceDateRange.Checked = false;
      checkBoxGetOrderStatus.Checked = false;
			textBoxUserId.Text = string.Empty;
			textBoxIPAddress.Text = string.Empty;
			textBoxNote.Text = string.Empty;
			label4.Text = string.Empty;
		}

    private void chbCheckAll_CheckedChanged(object sender, EventArgs e)
    {
      if (chbCheckAll.Checked == true)
      {
        checkBoxItem.Checked = true;
        checkBoxPostOrder.Checked = true;
        checkBoxGetBomComponents.Checked = true;
        checkBoxGetBomList.Checked = true;
        checkBoxGetCommonlyReplacedItems.Checked = true;
        checkBoxGetDailySales.Checked = true;
        checkBoxGetImageUrls.Checked = true;
        checkBoxGetInventoryListChanges.Checked = true;
        checkBoxGetMasterInventoryList.Checked = true;
        checkBoxGetMultipleItemDetail.Checked = true;
        checkBoxGetRealtimeItemStatus.Checked = true;
        checkBoxGetRecommendedItems.Checked = true;
        checkBoxGetSalesOrder.Checked = true;
        checkBoxGetSpecialPricedItems.Checked = true;
        checkBoxGetTrackingNumber.Checked = true;
        checkBoxGetTrackingNumberByDate.Checked = true;
        checkBoxGetCredits.Checked = true;
        checkBoxGetInventoryOnHand.Checked = true;
        checkBoxGetInvoice.Checked = true;
        checkBoxGetInvoiceByPonum.Checked = true;
        checkBoxGetInvoiceDateRange.Checked = true;
        checkBoxGetOrderStatus.Checked = true;
      }
      else
      {
        checkBoxItem.Checked = false;
        checkBoxPostOrder.Checked = false;
        checkBoxGetBomComponents.Checked = false;
        checkBoxGetBomList.Checked = false;
        checkBoxGetCommonlyReplacedItems.Checked = false;
        checkBoxGetDailySales.Checked = false;
        checkBoxGetImageUrls.Checked = false;
        checkBoxGetInventoryListChanges.Checked = false;
        checkBoxGetMasterInventoryList.Checked = false;
        checkBoxGetMultipleItemDetail.Checked = false;
        checkBoxGetRealtimeItemStatus.Checked = false;
        checkBoxGetRecommendedItems.Checked = false;
        checkBoxGetSalesOrder.Checked = false;
        checkBoxGetSpecialPricedItems.Checked = false;
        checkBoxGetTrackingNumber.Checked = false;
        checkBoxGetTrackingNumberByDate.Checked = false;
        checkBoxGetCredits.Checked = false;
        checkBoxGetInventoryOnHand.Checked = false;
        checkBoxGetInvoice.Checked = false;
        checkBoxGetInvoiceByPonum.Checked = false;
        checkBoxGetInvoiceDateRange.Checked = false;
        checkBoxGetOrderStatus.Checked = false;
      }
    }

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			DialogResult myResult;
			myResult = MessageBox.Show("Are you really delete this user?", "Delete Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Stop);
			if (myResult == DialogResult.Yes)
			{
				var selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
				if (selectedRowCount > 0)
				{
					for (var i = 0; i < selectedRowCount; i++)
					{
						label4.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
						string sql = null;
						sql = "DELETE FROM WebServiceAccess WHERE UserId='" + label4.Text + "' AND IPAddress='" + textBoxIPAddress.Text + "'";

						var conn = new SqlConnection(connectionString);
						try
						{
							conn.Open();
							var comm = new SqlCommand(sql, conn);
							comm.ExecuteNonQuery();
							comm.Dispose();
							conn.Close();
							MessageBox.Show(" User Account Deleted");
							webServiceAccessTableAdapter.Fill(hspp1devo3DataSet.WebServiceAccess);
							resetUser();
						}
						catch (Exception ex)
						{
							MessageBox.Show("Can not open connection ! ");
						}
					}
				}
			}
		}

		private void buttonCreate_Click(object sender, EventArgs e)
		{
			string sql = null;
			var conn = new SqlConnection(connectionString);
			try
			{
				if (checkBoxItem.CheckState == CheckState.Checked)
				{
					conn.Open();
					sql = "INSERT INTO WebServiceAccess (UserId, IPAddress, MethodName, VisibleProperties, Note) VALUES ('" + textBoxUserId.Text + "','" + textBoxIPAddress.Text + "', 'Item', 'all', '" + textBoxNote.Text + "')";
					var comm = new SqlCommand(sql, conn);
					comm.ExecuteNonQuery();
					comm.Dispose();
					conn.Close();
				}
				if (checkBoxPostOrder.CheckState == CheckState.Checked)
				{
					conn.Open();
					sql = "INSERT INTO WebServiceAccess (UserId, IPAddress, MethodName, VisibleProperties, Note) VALUES ('" + textBoxUserId.Text + "','" + textBoxIPAddress.Text + "', 'PostOrder', 'all', '" + textBoxNote.Text + "')";
					var comm = new SqlCommand(sql, conn);
					comm.ExecuteNonQuery();
					comm.Dispose();
					conn.Close();
				}
				if (checkBoxGetBomComponents.CheckState == CheckState.Checked)
				{
					conn.Open();
					sql = "INSERT INTO WebServiceAccess (UserId, IPAddress, MethodName, VisibleProperties, Note) VALUES ('" + textBoxUserId.Text + "','" + textBoxIPAddress.Text + "', 'GetBomComponents', 'all', '" + textBoxNote.Text + "')";
					var comm = new SqlCommand(sql, conn);
					comm.ExecuteNonQuery();
					comm.Dispose();
					conn.Close();
				}
				if (checkBoxGetBomList.CheckState == CheckState.Checked)
				{
					conn.Open();
					sql = "INSERT INTO WebServiceAccess (UserId, IPAddress, MethodName, VisibleProperties, Note) VALUES ('" + textBoxUserId.Text + "','" + textBoxIPAddress.Text + "', 'GetBomList', 'all', '" + textBoxNote.Text + "')";
					var comm = new SqlCommand(sql, conn);
					comm.ExecuteNonQuery();
					comm.Dispose();
					conn.Close();
				}
				if (checkBoxGetCommonlyReplacedItems.CheckState == CheckState.Checked)
				{
					conn.Open();
					sql = "INSERT INTO WebServiceAccess (UserId, IPAddress, MethodName, VisibleProperties, Note) VALUES ('" + textBoxUserId.Text + "','" + textBoxIPAddress.Text + "', 'GetCommonlyReplacedItems', 'all', '" + textBoxNote.Text + "')";
					var comm = new SqlCommand(sql, conn);
					comm.ExecuteNonQuery();
					comm.Dispose();
					conn.Close();
				}
				if (checkBoxGetDailySales.CheckState == CheckState.Checked)
				{
					conn.Open();
					sql = "INSERT INTO WebServiceAccess (UserId, IPAddress, MethodName, VisibleProperties, Note) VALUES ('" + textBoxUserId.Text + "','" + textBoxIPAddress.Text + "', 'GetDailySales', 'all', '" + textBoxNote.Text + "')";
					var comm = new SqlCommand(sql, conn);
					comm.ExecuteNonQuery();
					comm.Dispose();
					conn.Close();
				}
				if (checkBoxGetImageUrls.CheckState == CheckState.Checked)
				{
					conn.Open();
					sql = "INSERT INTO WebServiceAccess (UserId, IPAddress, MethodName, VisibleProperties, Note) VALUES ('" + textBoxUserId.Text + "','" + textBoxIPAddress.Text + "', 'GetImageUrls', 'all', '" + textBoxNote.Text + "')";
					var comm = new SqlCommand(sql, conn);
					comm.ExecuteNonQuery();
					comm.Dispose();
					conn.Close();
				}
				if (checkBoxGetInventoryListChanges.CheckState == CheckState.Checked)
				{
					conn.Open();
					sql = "INSERT INTO WebServiceAccess (UserId, IPAddress, MethodName, VisibleProperties, Note) VALUES ('" + textBoxUserId.Text + "','" + textBoxIPAddress.Text + "', 'GetInventoryListChanges', 'all', '" + textBoxNote.Text + "')";
					var comm = new SqlCommand(sql, conn);
					comm.ExecuteNonQuery();
					comm.Dispose();
					conn.Close();
				}
				if (checkBoxGetMasterInventoryList.CheckState == CheckState.Checked)
				{
					conn.Open();
					sql = "INSERT INTO WebServiceAccess (UserId, IPAddress, MethodName, VisibleProperties, Note) VALUES ('" + textBoxUserId.Text + "','" + textBoxIPAddress.Text + "', 'GetMasterInventoryList', 'all', '" + textBoxNote.Text + "')";
					var comm = new SqlCommand(sql, conn);
					comm.ExecuteNonQuery();
					comm.Dispose();
					conn.Close();
				}
				if (checkBoxGetMultipleItemDetail.CheckState == CheckState.Checked)
				{
					conn.Open();
					sql = "INSERT INTO WebServiceAccess (UserId, IPAddress, MethodName, VisibleProperties, Note) VALUES ('" + textBoxUserId.Text + "','" + textBoxIPAddress.Text + "', 'GetMultipleItemDetail', 'all', '" + textBoxNote.Text + "')";
					var comm = new SqlCommand(sql, conn);
					comm.ExecuteNonQuery();
					comm.Dispose();
					conn.Close();
				}
				if (checkBoxGetRealtimeItemStatus.CheckState == CheckState.Checked)
				{
					conn.Open();
					sql = "INSERT INTO WebServiceAccess (UserId, IPAddress, MethodName, VisibleProperties, Note) VALUES ('" + textBoxUserId.Text + "','" + textBoxIPAddress.Text + "', 'GetRealtimeItemStatus', 'all', '" + textBoxNote.Text + "')";
					var comm = new SqlCommand(sql, conn);
					comm.ExecuteNonQuery();
					comm.Dispose();
					conn.Close();
				}
				if (checkBoxGetRecommendedItems.CheckState == CheckState.Checked)
				{
					conn.Open();
					sql = "INSERT INTO WebServiceAccess (UserId, IPAddress, MethodName, VisibleProperties, Note) VALUES ('" + textBoxUserId.Text + "','" + textBoxIPAddress.Text + "', 'GetRecommendedItems', 'all', '" + textBoxNote.Text + "')";
					var comm = new SqlCommand(sql, conn);
					comm.ExecuteNonQuery();
					comm.Dispose();
					conn.Close();
				}
				if (checkBoxGetSalesOrder.CheckState == CheckState.Checked)
				{
					conn.Open();
					sql = "INSERT INTO WebServiceAccess (UserId, IPAddress, MethodName, VisibleProperties, Note) VALUES ('" + textBoxUserId.Text + "','" + textBoxIPAddress.Text + "', 'GetSalesOrder', 'all', '" + textBoxNote.Text + "')";
					var comm = new SqlCommand(sql, conn);
					comm.ExecuteNonQuery();
					comm.Dispose();
					conn.Close();
				}
				if (checkBoxGetSpecialPricedItems.CheckState == CheckState.Checked)
				{
					conn.Open();
					sql = "INSERT INTO WebServiceAccess (UserId, IPAddress, MethodName, VisibleProperties, Note) VALUES ('" + textBoxUserId.Text + "','" + textBoxIPAddress.Text + "', 'GetSpecialPricedItems', 'all', '" + textBoxNote.Text + "')";
					var comm = new SqlCommand(sql, conn);
					comm.ExecuteNonQuery();
					comm.Dispose();
					conn.Close();
				}
				if (checkBoxGetTrackingNumber.CheckState == CheckState.Checked)
				{
					conn.Open();
					sql = "INSERT INTO WebServiceAccess (UserId, IPAddress, MethodName, VisibleProperties, Note) VALUES ('" + textBoxUserId.Text + "','" + textBoxIPAddress.Text + "', 'GetTrackingNumber', 'all', '" + textBoxNote.Text + "')";
					var comm = new SqlCommand(sql, conn);
					comm.ExecuteNonQuery();
					comm.Dispose();
					conn.Close();
				}
				if (checkBoxGetTrackingNumberByDate.CheckState == CheckState.Checked)
				{
					conn.Open();
					sql = "INSERT INTO WebServiceAccess (UserId, IPAddress, MethodName, VisibleProperties, Note) VALUES ('" + textBoxUserId.Text + "','" + textBoxIPAddress.Text + "', 'GetTrackingNumberByDate', 'all', '" + textBoxNote.Text + "')";
					var comm = new SqlCommand(sql, conn);
					comm.ExecuteNonQuery();
					comm.Dispose();
					conn.Close();
				}
        if (checkBoxGetCredits.CheckState == CheckState.Checked)
        {
          conn.Open();
          sql = "INSERT INTO WebServiceAccess (UserId, IPAddress, MethodName, VisibleProperties, Note) VALUES ('" + textBoxUserId.Text + "','" + textBoxIPAddress.Text + "', 'GetCredits', 'all', '" + textBoxNote.Text + "')";
          var comm = new SqlCommand(sql, conn);
          comm.ExecuteNonQuery();
          comm.Dispose();
          conn.Close();
        }
        if (checkBoxGetInventoryOnHand.CheckState == CheckState.Checked)
        {
          conn.Open();
          sql = "INSERT INTO WebServiceAccess (UserId, IPAddress, MethodName, VisibleProperties, Note) VALUES ('" + textBoxUserId.Text + "','" + textBoxIPAddress.Text + "', 'GetInventoryOnHand', 'all', '" + textBoxNote.Text + "')";
          var comm = new SqlCommand(sql, conn);
          comm.ExecuteNonQuery();
          comm.Dispose();
          conn.Close();
        }
        if (checkBoxGetInvoice.CheckState == CheckState.Checked)
        {
          conn.Open();
          sql = "INSERT INTO WebServiceAccess (UserId, IPAddress, MethodName, VisibleProperties, Note) VALUES ('" + textBoxUserId.Text + "','" + textBoxIPAddress.Text + "', 'GetInvoice', 'all', '" + textBoxNote.Text + "')";
          var comm = new SqlCommand(sql, conn);
          comm.ExecuteNonQuery();
          comm.Dispose();
          conn.Close();
        }
        if (checkBoxGetInvoiceByPonum.CheckState == CheckState.Checked)
        {
          conn.Open();
          sql = "INSERT INTO WebServiceAccess (UserId, IPAddress, MethodName, VisibleProperties, Note) VALUES ('" + textBoxUserId.Text + "','" + textBoxIPAddress.Text + "', 'GetInvoiceByPonum', 'all', '" + textBoxNote.Text + "')";
          var comm = new SqlCommand(sql, conn);
          comm.ExecuteNonQuery();
          comm.Dispose();
          conn.Close();
        }
        if (checkBoxGetInvoiceDateRange.CheckState == CheckState.Checked)
        {
          conn.Open();
          sql = "INSERT INTO WebServiceAccess (UserId, IPAddress, MethodName, VisibleProperties, Note) VALUES ('" + textBoxUserId.Text + "','" + textBoxIPAddress.Text + "', 'GetInvoiceDateRange', 'all', '" + textBoxNote.Text + "')";
          var comm = new SqlCommand(sql, conn);
          comm.ExecuteNonQuery();
          comm.Dispose();
          conn.Close();
        }
        if (checkBoxGetOrderStatus.CheckState == CheckState.Checked)
        {
          conn.Open();
          sql = "INSERT INTO WebServiceAccess (UserId, IPAddress, MethodName, VisibleProperties, Note) VALUES ('" + textBoxUserId.Text + "','" + textBoxIPAddress.Text + "', 'GetOrderStatus', 'all', '" + textBoxNote.Text + "')";
          var comm = new SqlCommand(sql, conn);
          comm.ExecuteNonQuery();
          comm.Dispose();
          conn.Close();
        }
				MessageBox.Show(" User Account Created");
				resetUser();
				webServiceAccessTableAdapter.Fill(hspp1devo3DataSet.WebServiceAccess);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Can not open connection ! ");
			}
		}

		private void buttonReset_Click(object sender, EventArgs e)
		{
			resetUser();
			webServiceAccessTableAdapter.Fill(hspp1devo3DataSet.WebServiceAccess);
			textBoxNote.Enabled = true;
			textBoxIPAddress.Enabled = true;
			textBoxUserId.Enabled = true;
		}
	}
}
