using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 返回签到消息 message
 */
public class ResSigninInfoMessage : Message 
{
	//玩家签到信息
	SigninInfo _signInfo;	
	//时区偏移值(小时)
	int _timezoneOffset;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//玩家签到信息
		SerializeUtils.WriteBean(stream, _signInfo);
		//时区偏移值(小时)
		SerializeUtils.WriteInt(stream, _timezoneOffset);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//玩家签到信息
		_signInfo = SerializeUtils.ReadBean<SigninInfo>(stream);
		//时区偏移值(小时)
		_timezoneOffset = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 玩家签到信息
	 */
	public SigninInfo SignInfo
	{
		set { _signInfo = value; }
	    get { return _signInfo; }
	}
	
	/**
	 * 时区偏移值(小时)
	 */
	public int TimezoneOffset
	{
		set { _timezoneOffset = value; }
	    get { return _timezoneOffset; }
	}
	
	
	public override int GetId() 
	{
		return 305300;
	}
}