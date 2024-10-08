using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 多倍魂玉已购买的商品id message
 */
public class ResSoulBingoCommodityMessage : Message 
{
	//多倍魂玉已购买的商品ids
	List<int> _commodityIds = new List<int>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//多倍魂玉已购买的商品ids
		SerializeUtils.WriteShort(stream, (short)_commodityIds.Count);

		foreach (var element in _commodityIds)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//多倍魂玉已购买的商品ids
		int _commodityIds_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _commodityIds_length; ++i) 
		{
			_commodityIds.Add(SerializeUtils.ReadInt(stream));
		}
	}
	
	/**
	 * get 多倍魂玉已购买的商品ids
	 * @return 
	 */
	public List<int> GetCommodityIds()
	{
		return _commodityIds;
	}
	
	/**
	 * set 多倍魂玉已购买的商品ids
	 */
	public void SetCommodityIds(List<int> commodityIds)
	{
		_commodityIds = commodityIds;
	}
	
	
	public override int GetId() 
	{
		return 312108;
	}
}