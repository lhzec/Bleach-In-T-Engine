using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 返回端请求签到结果 message
 */
public class ResSigninMessage : Message 
{
	//灵魂能力升级结果消息id（0：成功，非0：失败的消息id）
	int _msg;	
	//签到类型（0：普通签到，1：补签）
	int _type;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//灵魂能力升级结果消息id（0：成功，非0：失败的消息id）
		SerializeUtils.WriteInt(stream, _msg);
		//签到类型（0：普通签到，1：补签）
		SerializeUtils.WriteInt(stream, _type);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//灵魂能力升级结果消息id（0：成功，非0：失败的消息id）
		_msg = SerializeUtils.ReadInt(stream);
		//签到类型（0：普通签到，1：补签）
		_type = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 灵魂能力升级结果消息id（0：成功，非0：失败的消息id）
	 */
	public int Msg
	{
		set { _msg = value; }
	    get { return _msg; }
	}
	
	/**
	 * 签到类型（0：普通签到，1：补签）
	 */
	public int Type
	{
		set { _type = value; }
	    get { return _type; }
	}
	
	
	public override int GetId() 
	{
		return 305101;
	}
}