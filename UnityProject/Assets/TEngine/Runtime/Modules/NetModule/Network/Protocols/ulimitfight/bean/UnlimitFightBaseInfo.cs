using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 极限对决基础信息
 */
public class UnlimitFightBaseInfo : IMessageSerialize 
{
	//极限对决编号
	int _id;	
	//战斗的次数
	int _fightTimes;	
	//剩余的免费次数
	int _freeTimesLeft;	
	//是否是特殊boss,特殊boss不可以扫荡[1:是特殊boss,0:不是特殊boss]
	int _bossType;	
	//是否通过[1:通过,0:未通过]
	int _pass;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//极限对决编号
		SerializeUtils.WriteInt(stream, _id);
		//战斗的次数
		SerializeUtils.WriteInt(stream, _fightTimes);
		//剩余的免费次数
		SerializeUtils.WriteInt(stream, _freeTimesLeft);
		//是否是特殊boss,特殊boss不可以扫荡[1:是特殊boss,0:不是特殊boss]
		SerializeUtils.WriteInt(stream, _bossType);
		//是否通过[1:通过,0:未通过]
		SerializeUtils.WriteInt(stream, _pass);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//极限对决编号
		_id = SerializeUtils.ReadInt(stream);
		//战斗的次数
		_fightTimes = SerializeUtils.ReadInt(stream);
		//剩余的免费次数
		_freeTimesLeft = SerializeUtils.ReadInt(stream);
		//是否是特殊boss,特殊boss不可以扫荡[1:是特殊boss,0:不是特殊boss]
		_bossType = SerializeUtils.ReadInt(stream);
		//是否通过[1:通过,0:未通过]
		_pass = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 极限对决编号
	 */
	public int Id
	{
		set { _id = value; }
	    get { return _id; }
	}
	
	/**
	 * 战斗的次数
	 */
	public int FightTimes
	{
		set { _fightTimes = value; }
	    get { return _fightTimes; }
	}
	
	/**
	 * 剩余的免费次数
	 */
	public int FreeTimesLeft
	{
		set { _freeTimesLeft = value; }
	    get { return _freeTimesLeft; }
	}
	
	/**
	 * 是否是特殊boss,特殊boss不可以扫荡[1:是特殊boss,0:不是特殊boss]
	 */
	public int BossType
	{
		set { _bossType = value; }
	    get { return _bossType; }
	}
	
	/**
	 * 是否通过[1:通过,0:未通过]
	 */
	public int Pass
	{
		set { _pass = value; }
	    get { return _pass; }
	}
	
}