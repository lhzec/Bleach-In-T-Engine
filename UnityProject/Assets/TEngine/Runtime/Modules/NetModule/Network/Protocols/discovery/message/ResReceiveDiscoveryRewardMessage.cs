using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 返回前端请求领取探索奖励 message
 */
public class ResReceiveDiscoveryRewardMessage : Message 
{
	//开始探索结果消息id（0：成功，非0：失败的消息id）
	int _msg;	
	//物品奖励信息（灵子奖励和物品奖励）
	List<ItemInfo> _baseRewardInfos = new List<ItemInfo>();
	//物品奖励信息（灵子奖励，金钱奖励（环），物品奖励）
	List<ItemInfo> _treasureRewardInfos = new List<ItemInfo>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//开始探索结果消息id（0：成功，非0：失败的消息id）
		SerializeUtils.WriteInt(stream, _msg);
		//物品奖励信息（灵子奖励和物品奖励）
		SerializeUtils.WriteShort(stream, (short)_baseRewardInfos.Count);

		foreach (var element in _baseRewardInfos)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//物品奖励信息（灵子奖励，金钱奖励（环），物品奖励）
		SerializeUtils.WriteShort(stream, (short)_treasureRewardInfos.Count);

		foreach (var element in _treasureRewardInfos)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//开始探索结果消息id（0：成功，非0：失败的消息id）
		_msg = SerializeUtils.ReadInt(stream);
		//物品奖励信息（灵子奖励和物品奖励）
		int _baseRewardInfos_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _baseRewardInfos_length; ++i) 
		{
			_baseRewardInfos.Add(SerializeUtils.ReadBean<ItemInfo>(stream));
		}
		//物品奖励信息（灵子奖励，金钱奖励（环），物品奖励）
		int _treasureRewardInfos_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _treasureRewardInfos_length; ++i) 
		{
			_treasureRewardInfos.Add(SerializeUtils.ReadBean<ItemInfo>(stream));
		}
	}
	
	/**
	 * 开始探索结果消息id（0：成功，非0：失败的消息id）
	 */
	public int Msg
	{
		set { _msg = value; }
	    get { return _msg; }
	}
	
	/**
	 * get 物品奖励信息（灵子奖励和物品奖励）
	 * @return 
	 */
	public List<ItemInfo> GetBaseRewardInfos()
	{
		return _baseRewardInfos;
	}
	
	/**
	 * set 物品奖励信息（灵子奖励和物品奖励）
	 */
	public void SetBaseRewardInfos(List<ItemInfo> baseRewardInfos)
	{
		_baseRewardInfos = baseRewardInfos;
	}
	
	/**
	 * get 物品奖励信息（灵子奖励，金钱奖励（环），物品奖励）
	 * @return 
	 */
	public List<ItemInfo> GetTreasureRewardInfos()
	{
		return _treasureRewardInfos;
	}
	
	/**
	 * set 物品奖励信息（灵子奖励，金钱奖励（环），物品奖励）
	 */
	public void SetTreasureRewardInfos(List<ItemInfo> treasureRewardInfos)
	{
		_treasureRewardInfos = treasureRewardInfos;
	}
	
	
	public override int GetId() 
	{
		return 303102;
	}
}