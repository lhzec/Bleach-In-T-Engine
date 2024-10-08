using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 折扣
 */
public class DiscountInfo : IMessageSerialize 
{
	//201:浦原商店 202:竞技商店203:番队商店204灵魂试炼商店，其他参见SystemType
	int _type;	
	//折扣万分比
	int _discount;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//201:浦原商店 202:竞技商店203:番队商店204灵魂试炼商店，其他参见SystemType
		SerializeUtils.WriteInt(stream, _type);
		//折扣万分比
		SerializeUtils.WriteInt(stream, _discount);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//201:浦原商店 202:竞技商店203:番队商店204灵魂试炼商店，其他参见SystemType
		_type = SerializeUtils.ReadInt(stream);
		//折扣万分比
		_discount = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 201:浦原商店 202:竞技商店203:番队商店204灵魂试炼商店，其他参见SystemType
	 */
	public int Type
	{
		set { _type = value; }
	    get { return _type; }
	}
	
	/**
	 * 折扣万分比
	 */
	public int Discount
	{
		set { _discount = value; }
	    get { return _discount; }
	}
	
}