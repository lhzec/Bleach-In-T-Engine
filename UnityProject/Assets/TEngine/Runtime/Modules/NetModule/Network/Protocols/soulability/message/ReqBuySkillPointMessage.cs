using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 前端请求购买技能点 message
 */
public class ReqBuySkillPointMessage : Message 
{
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
	}
	
	
	public override int GetId() 
	{
		return 304202;
	}
}