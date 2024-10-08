using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 地狱蝶抢夺纪录
 */
public class ButterflyRobRecord : IMessageSerialize 
{
	//抢夺纪录Id
	long _robId;	
	//抢夺类型，0：被抢， 1：抢别人
	int _type;	
	//抢夺是否成功，0-失败，1成功
	int _isWin;	
	//抢夺地狱蝶个数
	int _robCount;	
	//对手名字
	string _playerName;	
	//对手角色列表
	List<ArenaFightCharacterInfo> _oppoCharacterInfos = new List<ArenaFightCharacterInfo>();
	//发生时间，0：一小时内，其他：几小时前
	int _fightTime;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//抢夺纪录Id
		SerializeUtils.WriteLong(stream, _robId);
		//抢夺类型，0：被抢， 1：抢别人
		SerializeUtils.WriteInt(stream, _type);
		//抢夺是否成功，0-失败，1成功
		SerializeUtils.WriteInt(stream, _isWin);
		//抢夺地狱蝶个数
		SerializeUtils.WriteInt(stream, _robCount);
		//对手名字
		SerializeUtils.WriteString(stream, _playerName);
		//对手角色列表
		SerializeUtils.WriteShort(stream, (short)_oppoCharacterInfos.Count);

		foreach (var element in _oppoCharacterInfos)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//发生时间，0：一小时内，其他：几小时前
		SerializeUtils.WriteInt(stream, _fightTime);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//抢夺纪录Id
		_robId = SerializeUtils.ReadLong(stream);
		//抢夺类型，0：被抢， 1：抢别人
		_type = SerializeUtils.ReadInt(stream);
		//抢夺是否成功，0-失败，1成功
		_isWin = SerializeUtils.ReadInt(stream);
		//抢夺地狱蝶个数
		_robCount = SerializeUtils.ReadInt(stream);
		//对手名字
		_playerName = SerializeUtils.ReadString(stream);
		//对手角色列表
		int _oppoCharacterInfos_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _oppoCharacterInfos_length; ++i) 
		{
			_oppoCharacterInfos.Add(SerializeUtils.ReadBean<ArenaFightCharacterInfo>(stream));
		}
		//发生时间，0：一小时内，其他：几小时前
		_fightTime = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 抢夺纪录Id
	 */
	public long RobId
	{
		set { _robId = value; }
	    get { return _robId; }
	}
	
	/**
	 * 抢夺类型，0：被抢， 1：抢别人
	 */
	public int Type
	{
		set { _type = value; }
	    get { return _type; }
	}
	
	/**
	 * 抢夺是否成功，0-失败，1成功
	 */
	public int IsWin
	{
		set { _isWin = value; }
	    get { return _isWin; }
	}
	
	/**
	 * 抢夺地狱蝶个数
	 */
	public int RobCount
	{
		set { _robCount = value; }
	    get { return _robCount; }
	}
	
	/**
	 * 对手名字
	 */
	public string PlayerName
	{
		set { _playerName = value; }
	    get { return _playerName; }
	}
	
	/**
	 * get 对手角色列表
	 * @return 
	 */
	public List<ArenaFightCharacterInfo> GetOppoCharacterInfos()
	{
		return _oppoCharacterInfos;
	}
	
	/**
	 * set 对手角色列表
	 */
	public void SetOppoCharacterInfos(List<ArenaFightCharacterInfo> oppoCharacterInfos)
	{
		_oppoCharacterInfos = oppoCharacterInfos;
	}
	
	/**
	 * 发生时间，0：一小时内，其他：几小时前
	 */
	public int FightTime
	{
		set { _fightTime = value; }
	    get { return _fightTime; }
	}
	
}