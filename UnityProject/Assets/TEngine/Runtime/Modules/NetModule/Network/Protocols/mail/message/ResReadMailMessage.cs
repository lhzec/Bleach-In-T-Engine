using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 读邮件回复 message
 */
public class ResReadMailMessage : Message 
{
	//0：成功，1：邮件不存在，2：邮件已读
	int _result;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0：成功，1：邮件不存在，2：邮件已读
		SerializeUtils.WriteInt(stream, _result);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0：成功，1：邮件不存在，2：邮件已读
		_result = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 0：成功，1：邮件不存在，2：邮件已读
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	
	public override int GetId() 
	{
		return 500101;
	}
}