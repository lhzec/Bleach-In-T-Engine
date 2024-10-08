using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 连续登录天数 message
 */
public class ResContinuousLoginMessage : Message 
{
	//连续天数
	int _day;	
	//最大连续天数
	int _maxDay;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//连续天数
		SerializeUtils.WriteInt(stream, _day);
		//最大连续天数
		SerializeUtils.WriteInt(stream, _maxDay);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//连续天数
		_day = SerializeUtils.ReadInt(stream);
		//最大连续天数
		_maxDay = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 连续天数
	 */
	public int Day
	{
		set { _day = value; }
	    get { return _day; }
	}
	
	/**
	 * 最大连续天数
	 */
	public int MaxDay
	{
		set { _maxDay = value; }
	    get { return _maxDay; }
	}
	
	
	public override int GetId() 
	{
		return 100104;
	}
}