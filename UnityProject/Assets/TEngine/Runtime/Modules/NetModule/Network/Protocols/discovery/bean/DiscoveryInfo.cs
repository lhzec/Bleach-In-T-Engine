using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 探索信息
 */
public class DiscoveryInfo : IMessageSerialize 
{
	//当前探索id
	int _discoveryId;	
	//正在探索的角色
	List<int> _discoveryCharacters = new List<int>();
	//已探索时长（0为未探索，大于0小于探索配置时长为探索中，大于等于探索配置时长探索完成），单位为毫秒
	long _discoveryTime;	
	//已打开宝箱数量
	int _openedChestNum;	
	//今日探索已经使用过的角色
	List<int> _discoveryTodayUsedCharacters = new List<int>();
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//当前探索id
		SerializeUtils.WriteInt(stream, _discoveryId);
		//正在探索的角色
		SerializeUtils.WriteShort(stream, (short)_discoveryCharacters.Count);

		foreach (var element in _discoveryCharacters)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
		//已探索时长（0为未探索，大于0小于探索配置时长为探索中，大于等于探索配置时长探索完成），单位为毫秒
		SerializeUtils.WriteLong(stream, _discoveryTime);
		//已打开宝箱数量
		SerializeUtils.WriteInt(stream, _openedChestNum);
		//今日探索已经使用过的角色
		SerializeUtils.WriteShort(stream, (short)_discoveryTodayUsedCharacters.Count);

		foreach (var element in _discoveryTodayUsedCharacters)  
		{
			SerializeUtils.WriteInt(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//当前探索id
		_discoveryId = SerializeUtils.ReadInt(stream);
		//正在探索的角色
		int _discoveryCharacters_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _discoveryCharacters_length; ++i) 
		{
			_discoveryCharacters.Add(SerializeUtils.ReadInt(stream));
		}
		//已探索时长（0为未探索，大于0小于探索配置时长为探索中，大于等于探索配置时长探索完成），单位为毫秒
		_discoveryTime = SerializeUtils.ReadLong(stream);
		//已打开宝箱数量
		_openedChestNum = SerializeUtils.ReadInt(stream);
		//今日探索已经使用过的角色
		int _discoveryTodayUsedCharacters_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _discoveryTodayUsedCharacters_length; ++i) 
		{
			_discoveryTodayUsedCharacters.Add(SerializeUtils.ReadInt(stream));
		}
	}
	
	/**
	 * 当前探索id
	 */
	public int DiscoveryId
	{
		set { _discoveryId = value; }
	    get { return _discoveryId; }
	}
	
	/**
	 * get 正在探索的角色
	 * @return 
	 */
	public List<int> GetDiscoveryCharacters()
	{
		return _discoveryCharacters;
	}
	
	/**
	 * set 正在探索的角色
	 */
	public void SetDiscoveryCharacters(List<int> discoveryCharacters)
	{
		_discoveryCharacters = discoveryCharacters;
	}
	
	/**
	 * 已探索时长（0为未探索，大于0小于探索配置时长为探索中，大于等于探索配置时长探索完成），单位为毫秒
	 */
	public long DiscoveryTime
	{
		set { _discoveryTime = value; }
	    get { return _discoveryTime; }
	}
	
	/**
	 * 已打开宝箱数量
	 */
	public int OpenedChestNum
	{
		set { _openedChestNum = value; }
	    get { return _openedChestNum; }
	}
	
	/**
	 * get 今日探索已经使用过的角色
	 * @return 
	 */
	public List<int> GetDiscoveryTodayUsedCharacters()
	{
		return _discoveryTodayUsedCharacters;
	}
	
	/**
	 * set 今日探索已经使用过的角色
	 */
	public void SetDiscoveryTodayUsedCharacters(List<int> discoveryTodayUsedCharacters)
	{
		_discoveryTodayUsedCharacters = discoveryTodayUsedCharacters;
	}
	
}