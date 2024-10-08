using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 设置妹子时装 message
 */
public class ReqGirlDressMessage : Message 
{
	//妹子id
	int _girlId;	
	//当前时装id
	int _nowDress;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//妹子id
		SerializeUtils.WriteInt(stream, _girlId);
		//当前时装id
		SerializeUtils.WriteInt(stream, _nowDress);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//妹子id
		_girlId = SerializeUtils.ReadInt(stream);
		//当前时装id
		_nowDress = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 妹子id
	 */
	public int GirlId
	{
		set { _girlId = value; }
	    get { return _girlId; }
	}
	
	/**
	 * 当前时装id
	 */
	public int NowDress
	{
		set { _nowDress = value; }
	    get { return _nowDress; }
	}
	
	
	public override int GetId() 
	{
		return 108203;
	}
}