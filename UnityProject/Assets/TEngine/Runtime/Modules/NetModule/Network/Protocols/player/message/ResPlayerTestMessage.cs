using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 测试 message
 */
public class ResPlayerTestMessage : Message 
{
	//标识
	long _flag;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//标识
		SerializeUtils.WriteLong(stream, _flag);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//标识
		_flag = SerializeUtils.ReadLong(stream);
	}
	
	/**
	 * 标识
	 */
	public long Flag
	{
		set { _flag = value; }
	    get { return _flag; }
	}
	
	
	public override int GetId() 
	{
		return 105108;
	}
}