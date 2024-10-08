using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 关卡奖励信息
 */
public class LevelRewardInfo : IMessageSerialize 
{
	//固定奖励
	FixedRewardInfo _fixedRewardInfo;	
	//随机奖励
	List<ItemInfo> _randomRewardInfo = new List<ItemInfo>();
	//首次通关奖励
	List<ItemInfo> _firstFightReward = new List<ItemInfo>();
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//固定奖励
		SerializeUtils.WriteBean(stream, _fixedRewardInfo);
		//随机奖励
		SerializeUtils.WriteShort(stream, (short)_randomRewardInfo.Count);

		foreach (var element in _randomRewardInfo)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//首次通关奖励
		SerializeUtils.WriteShort(stream, (short)_firstFightReward.Count);

		foreach (var element in _firstFightReward)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//固定奖励
		_fixedRewardInfo = SerializeUtils.ReadBean<FixedRewardInfo>(stream);
		//随机奖励
		int _randomRewardInfo_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _randomRewardInfo_length; ++i) 
		{
			_randomRewardInfo.Add(SerializeUtils.ReadBean<ItemInfo>(stream));
		}
		//首次通关奖励
		int _firstFightReward_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _firstFightReward_length; ++i) 
		{
			_firstFightReward.Add(SerializeUtils.ReadBean<ItemInfo>(stream));
		}
	}
	
	/**
	 * 固定奖励
	 */
	public FixedRewardInfo FixedRewardInfo
	{
		set { _fixedRewardInfo = value; }
	    get { return _fixedRewardInfo; }
	}
	
	/**
	 * get 随机奖励
	 * @return 
	 */
	public List<ItemInfo> GetRandomRewardInfo()
	{
		return _randomRewardInfo;
	}
	
	/**
	 * set 随机奖励
	 */
	public void SetRandomRewardInfo(List<ItemInfo> randomRewardInfo)
	{
		_randomRewardInfo = randomRewardInfo;
	}
	
	/**
	 * get 首次通关奖励
	 * @return 
	 */
	public List<ItemInfo> GetFirstFightReward()
	{
		return _firstFightReward;
	}
	
	/**
	 * set 首次通关奖励
	 */
	public void SetFirstFightReward(List<ItemInfo> firstFightReward)
	{
		_firstFightReward = firstFightReward;
	}
	
}