using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 系统折扣 message
 */
public class ResPlayerActivityDiscountMessage : Message 
{
	//折扣
	List<DiscountInfo> _discounts = new List<DiscountInfo>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//折扣
		SerializeUtils.WriteShort(stream, (short)_discounts.Count);

		foreach (var element in _discounts)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//折扣
		int _discounts_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _discounts_length; ++i) 
		{
			_discounts.Add(SerializeUtils.ReadBean<DiscountInfo>(stream));
		}
	}
	
	/**
	 * get 折扣
	 * @return 
	 */
	public List<DiscountInfo> GetDiscounts()
	{
		return _discounts;
	}
	
	/**
	 * set 折扣
	 */
	public void SetDiscounts(List<DiscountInfo> discounts)
	{
		_discounts = discounts;
	}
	
	
	public override int GetId() 
	{
		return 105107;
	}
}