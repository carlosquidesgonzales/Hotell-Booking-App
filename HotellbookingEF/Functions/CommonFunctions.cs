using HotellbookingEF.Data;
using HotellbookingEF.Enum;
using HotellbookingEF.Exceptions;
using HotellbookingEF.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotellbookingEF.Functions
{
    public class CommonFunctions
    {
        IDataRepository _data = new DataRepository();
        public void AddEntity<TEntity>(TEntity entity, string entityName) where TEntity : class
        {
            try
            {
                _data.Add(entity);

            }
            catch (EntityException<Customer> ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
            catch
            {
                MessageBox.Show($"Could not add {entityName} data");
            }
        }
        public void UpdateEntity<TEntity>(TEntity entity, string entityName) where TEntity : class
        {
            try
            {
                _data.Update(entity);
            }
            catch (EntityException<Customer> ex)
            {
                MessageBox.Show($"{ex.Message}: {ex.Entity.Phone}");
            }
            catch
            {
                MessageBox.Show($"Could not update {entityName} data");
            }
        }
        public void DeleteEntity<TEntity>(TEntity entity, string entityName) where TEntity : class
        {
            try
            {
                _data.Delete(entity);
            }
            catch (EntityException<Customer> ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
            catch
            {
                MessageBox.Show($"Could not delete {entityName} data");
            }
        }
        public void RemoveUnpaidBookingAfterTenDays(BindingList<Booking> bookings, BindingList<Invoice> invoices)
        {
            var unpaidInvoiceIn = invoices.Where(i => i.InvoiceStatus == InvoiceStatus.Unpaid.ToString()).ToList();
            var unpaidBookings = bookings.Where(b => unpaidInvoiceIn.Any(u => u.BookingId == b.Id)).ToList();
            if (unpaidBookings.Count != 0)
            {
                foreach (var item in unpaidBookings)
                {
                    if ((DateTime.Now - item.BookingDate).Days >= 10)
                    {
                        _data.Delete(item);
                    }
                }
            }
        }
    }
}
