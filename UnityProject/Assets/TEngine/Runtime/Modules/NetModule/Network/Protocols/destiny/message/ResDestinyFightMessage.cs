using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 开始对决 message
 */
public class ResDestinyFightMessage : Message 
{
	//0-成功 1-宿命对决未开启 2-难度错误 3-体力不够 4-等级不够 5-今日已挑战 6-其他错误
	int _result;	
	//对决表索引id
	int _index;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0-成功 1-宿命对决未开启 2-难度错误 3-体力不够 4-等级不够 5-今日已挑战 6-其他错误
		SerializeUtils.WriteInt(stream, _result);
		//对决表索引id
		SerializeUtils.WriteInt(stream, _index);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0-成功 1-宿命对决未开启 2-难度错误 3-体力不够 4-等级不够 5-今日已挑战 6-其他错误
		_result = SerializeUtils.ReadInt(stream);
		//对决表索引id
		_index = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 0-成功 1-宿命对决未开启 2-难度错误 3-体力不够 4-等级不够 5-今日已挑战 6-其他错误
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	/**
	 * 对决表索引id
	 */
	public int Index
	{
		set { _index = value; }
	    get { return _index; }
	}
	
	
	public override int GetId() 
	{
		return 107102;
	}
}