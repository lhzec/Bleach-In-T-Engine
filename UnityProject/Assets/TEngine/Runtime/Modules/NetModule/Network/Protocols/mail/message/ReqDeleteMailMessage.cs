using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 删除邮件请求 message
 */
public class ReqDeleteMailMessage : Message 
{
	//邮件id
	long _mailId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//邮件id
		SerializeUtils.WriteLong(stream, _mailId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//邮件id
		_mailId = SerializeUtils.ReadLong(stream);
	}
	
	/**
	 * 邮件id
	 */
	public long MailId
	{
		set { _mailId = value; }
	    get { return _mailId; }
	}
	
	
	public override int GetId() 
	{
		return 500203;
	}
}