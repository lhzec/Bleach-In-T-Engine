using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 普通商品信息
 */
public class NormalCommodityInfo : IMessageSerialize 
{
	//商品Id
	int _commodityId;	
	//购买次数
	int _buyTime;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//商品Id
		SerializeUtils.WriteInt(stream, _commodityId);
		//购买次数
		SerializeUtils.WriteInt(stream, _buyTime);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//商品Id
		_commodityId = SerializeUtils.ReadInt(stream);
		//购买次数
		_buyTime = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 商品Id
	 */
	public int CommodityId
	{
		set { _commodityId = value; }
	    get { return _commodityId; }
	}
	
	/**
	 * 购买次数
	 */
	public int BuyTime
	{
		set { _buyTime = value; }
	    get { return _buyTime; }
	}
	
}