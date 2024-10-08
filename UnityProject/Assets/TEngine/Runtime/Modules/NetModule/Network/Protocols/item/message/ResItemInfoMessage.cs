using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 同步玩家所有物品信息 message
 */
public class ResItemInfoMessage : Message 
{
	//物品信息列表
	List<ItemInfo> _itemInfos = new List<ItemInfo>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//物品信息列表
		SerializeUtils.WriteShort(stream, (short)_itemInfos.Count);

		foreach (var element in _itemInfos)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//物品信息列表
		int _itemInfos_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _itemInfos_length; ++i) 
		{
			_itemInfos.Add(SerializeUtils.ReadBean<ItemInfo>(stream));
		}
	}
	
	/**
	 * get 物品信息列表
	 * @return 
	 */
	public List<ItemInfo> GetItemInfos()
	{
		return _itemInfos;
	}
	
	/**
	 * set 物品信息列表
	 */
	public void SetItemInfos(List<ItemInfo> itemInfos)
	{
		_itemInfos = itemInfos;
	}
	
	
	public override int GetId() 
	{
		return 101101;
	}
}