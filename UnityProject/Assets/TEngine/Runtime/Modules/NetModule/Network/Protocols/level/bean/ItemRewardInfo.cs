using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 物品奖励信息
 */
public class ItemRewardInfo : IMessageSerialize 
{
	//物品id
	int _itemId;	
	//物品数量
	int _itemCount;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//物品id
		SerializeUtils.WriteInt(stream, _itemId);
		//物品数量
		SerializeUtils.WriteInt(stream, _itemCount);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//物品id
		_itemId = SerializeUtils.ReadInt(stream);
		//物品数量
		_itemCount = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 物品id
	 */
	public int ItemId
	{
		set { _itemId = value; }
	    get { return _itemId; }
	}
	
	/**
	 * 物品数量
	 */
	public int ItemCount
	{
		set { _itemCount = value; }
	    get { return _itemCount; }
	}
	
}