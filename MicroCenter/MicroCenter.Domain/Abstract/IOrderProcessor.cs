using MicroCenter.Domain.Entities;

namespace MicroCenter.Domain.Abstract
{
	public interface IOrderProcessor
	{
		void ProcessOrder(Cart cart, ShippingDetails shippingDetails);
	}
}
