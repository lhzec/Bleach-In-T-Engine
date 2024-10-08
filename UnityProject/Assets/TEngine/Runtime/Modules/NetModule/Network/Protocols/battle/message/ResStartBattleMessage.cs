using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 开始战斗回复 message
 */
public class ResStartBattleMessage : Message 
{
	//0：成功  1：失败（状态异常）
	int _result;	
	//强化系数，万分比
	int _factor;	
	//战斗序号
	int _battleKey;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0：成功  1：失败（状态异常）
		SerializeUtils.WriteInt(stream, _result);
		//强化系数，万分比
		SerializeUtils.WriteInt(stream, _factor);
		//战斗序号
		SerializeUtils.WriteInt(stream, _battleKey);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0：成功  1：失败（状态异常）
		_result = SerializeUtils.ReadInt(stream);
		//强化系数，万分比
		_factor = SerializeUtils.ReadInt(stream);
		//战斗序号
		_battleKey = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 0：成功  1：失败（状态异常）
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	/**
	 * 强化系数，万分比
	 */
	public int Factor
	{
		set { _factor = value; }
	    get { return _factor; }
	}
	
	/**
	 * 战斗序号
	 */
	public int BattleKey
	{
		set { _battleKey = value; }
	    get { return _battleKey; }
	}
	
	
	public override int GetId() 
	{
		return 400201;
	}
}