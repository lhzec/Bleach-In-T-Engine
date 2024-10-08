using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 番队战角色以及战斗胜负次数信息 message
 */
public class ResGangBattlePlayerFightTimeInfoMessage : Message 
{
	//对应的角色编号
	long _playerId;	
	//胜利次数
	int _winTimes;	
	//已参战次数
	int _fightTimes;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//对应的角色编号
		SerializeUtils.WriteLong(stream, _playerId);
		//胜利次数
		SerializeUtils.WriteInt(stream, _winTimes);
		//已参战次数
		SerializeUtils.WriteInt(stream, _fightTimes);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//对应的角色编号
		_playerId = SerializeUtils.ReadLong(stream);
		//胜利次数
		_winTimes = SerializeUtils.ReadInt(stream);
		//已参战次数
		_fightTimes = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 对应的角色编号
	 */
	public long PlayerId
	{
		set { _playerId = value; }
	    get { return _playerId; }
	}
	
	/**
	 * 胜利次数
	 */
	public int WinTimes
	{
		set { _winTimes = value; }
	    get { return _winTimes; }
	}
	
	/**
	 * 已参战次数
	 */
	public int FightTimes
	{
		set { _fightTimes = value; }
	    get { return _fightTimes; }
	}
	
	
	public override int GetId() 
	{
		return 112118;
	}
}