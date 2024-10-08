using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 获取邮件附件回复 message
 */
public class ResGetMailAttachMessage : Message 
{
	//0：成功，1：附件不存在，2：附件已取
	int _result;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0：成功，1：附件不存在，2：附件已取
		SerializeUtils.WriteInt(stream, _result);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0：成功，1：附件不存在，2：附件已取
		_result = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 0：成功，1：附件不存在，2：附件已取
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	
	public override int GetId() 
	{
		return 500102;
	}
}