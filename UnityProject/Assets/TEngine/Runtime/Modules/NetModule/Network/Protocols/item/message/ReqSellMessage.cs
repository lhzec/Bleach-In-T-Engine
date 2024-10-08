using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 出售物品 message
 */
public class ReqSellMessage : Message 
{
	//样本id
	int _sid;	
	//数量
	int _num;	
	//单价
	int _price;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//样本id
		SerializeUtils.WriteInt(stream, _sid);
		//数量
		SerializeUtils.WriteInt(stream, _num);
		//单价
		SerializeUtils.WriteInt(stream, _price);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//样本id
		_sid = SerializeUtils.ReadInt(stream);
		//数量
		_num = SerializeUtils.ReadInt(stream);
		//单价
		_price = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 样本id
	 */
	public int Sid
	{
		set { _sid = value; }
	    get { return _sid; }
	}
	
	/**
	 * 数量
	 */
	public int Num
	{
		set { _num = value; }
	    get { return _num; }
	}
	
	/**
	 * 单价
	 */
	public int Price
	{
		set { _price = value; }
	    get { return _price; }
	}
	
	
	public override int GetId() 
	{
		return 801201;
	}
}