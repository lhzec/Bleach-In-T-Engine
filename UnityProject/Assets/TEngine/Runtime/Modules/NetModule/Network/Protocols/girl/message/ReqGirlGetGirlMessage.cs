using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 获取妹子 message
 */
public class ReqGirlGetGirlMessage : Message 
{
	//妹子id
	int _girlId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//妹子id
		SerializeUtils.WriteInt(stream, _girlId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//妹子id
		_girlId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 妹子id
	 */
	public int GirlId
	{
		set { _girlId = value; }
	    get { return _girlId; }
	}
	
	
	public override int GetId() 
	{
		return 108205;
	}
}