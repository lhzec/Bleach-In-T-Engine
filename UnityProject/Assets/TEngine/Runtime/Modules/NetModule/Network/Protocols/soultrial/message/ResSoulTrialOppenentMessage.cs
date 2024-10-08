using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 灵魂试炼对手信息 message
 */
public class ResSoulTrialOppenentMessage : Message 
{
	//灵魂试炼对手
	SoulTrialOppenentInfo _soulTrialOppenent;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//灵魂试炼对手
		SerializeUtils.WriteBean(stream, _soulTrialOppenent);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//灵魂试炼对手
		_soulTrialOppenent = SerializeUtils.ReadBean<SoulTrialOppenentInfo>(stream);
	}
	
	/**
	 * 灵魂试炼对手
	 */
	public SoulTrialOppenentInfo SoulTrialOppenent
	{
		set { _soulTrialOppenent = value; }
	    get { return _soulTrialOppenent; }
	}
	
	
	public override int GetId() 
	{
		return 204104;
	}
}