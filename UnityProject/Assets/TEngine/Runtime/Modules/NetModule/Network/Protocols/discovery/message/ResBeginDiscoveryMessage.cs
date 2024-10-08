using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 返回前端请求开始探索结果 message
 */
public class ResBeginDiscoveryMessage : Message 
{
	//开始探索结果消息id（0：成功，非0：失败的消息id）
	int _msg;	
	//探索总时长
	int _totalDiscoveryTime;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//开始探索结果消息id（0：成功，非0：失败的消息id）
		SerializeUtils.WriteInt(stream, _msg);
		//探索总时长
		SerializeUtils.WriteInt(stream, _totalDiscoveryTime);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//开始探索结果消息id（0：成功，非0：失败的消息id）
		_msg = SerializeUtils.ReadInt(stream);
		//探索总时长
		_totalDiscoveryTime = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 开始探索结果消息id（0：成功，非0：失败的消息id）
	 */
	public int Msg
	{
		set { _msg = value; }
	    get { return _msg; }
	}
	
	/**
	 * 探索总时长
	 */
	public int TotalDiscoveryTime
	{
		set { _totalDiscoveryTime = value; }
	    get { return _totalDiscoveryTime; }
	}
	
	
	public override int GetId() 
	{
		return 303101;
	}
}