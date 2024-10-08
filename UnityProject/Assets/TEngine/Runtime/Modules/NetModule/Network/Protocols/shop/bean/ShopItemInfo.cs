using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 商店道具信息
 */
public class ShopItemInfo : IMessageSerialize 
{
	//序号
	int _index;	
	//商品id
	int _shopItemId;	
	//商品剩余购买次数
	int _resNum;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//序号
		SerializeUtils.WriteInt(stream, _index);
		//商品id
		SerializeUtils.WriteInt(stream, _shopItemId);
		//商品剩余购买次数
		SerializeUtils.WriteInt(stream, _resNum);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//序号
		_index = SerializeUtils.ReadInt(stream);
		//商品id
		_shopItemId = SerializeUtils.ReadInt(stream);
		//商品剩余购买次数
		_resNum = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 序号
	 */
	public int Index
	{
		set { _index = value; }
	    get { return _index; }
	}
	
	/**
	 * 商品id
	 */
	public int ShopItemId
	{
		set { _shopItemId = value; }
	    get { return _shopItemId; }
	}
	
	/**
	 * 商品剩余购买次数
	 */
	public int ResNum
	{
		set { _resNum = value; }
	    get { return _resNum; }
	}
	
}